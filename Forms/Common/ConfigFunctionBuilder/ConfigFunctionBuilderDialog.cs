using SIF.Utils.Forms.JsonBuilder.Register;
using SIF.Utils.Logic.ConfigFunctionParser;
using System.Text.Json;

namespace SIF.Utils.Forms.Common.ConfigFunctionBuilder
{
    /// <summary>
    /// Reusable "build a SIF config function expression" dialog. Seeds an editable
    /// ConfigFunctionModel/ConfigFunctionParameter tree from an existing value (if it already looks
    /// like a config function), lets the user author it via a tree + per-node editor, and produces
    /// the resulting value text via GetResult().
    /// </summary>
    public partial class ConfigFunctionBuilderDialog : Form
    {
        private readonly ConfigFunctionParameter _root;
        private readonly ConfigFunctionEditingContext _context;
        private readonly ConfigFunctionArgumentEditor _editor = new() { Dock = DockStyle.Fill };
        private ConfigFunctionParameter? _selected;
        private ConfigFunctionParameter? _loadedInEditor;

        public ConfigFunctionBuilderDialog(
            string? seedValue,
            IEnumerable<string> availableVariables,
            IEnumerable<string> availableParameters,
            IEnumerable<RegisterMethodModel> registeredConfigFunctions)
        {
            InitializeComponent();

            var functionNames = KnownConfigFunctions.All.Select(f => f.Name)
                .Concat(registeredConfigFunctions.Select(r => r.RegisterAs))
                .Where(n => !string.IsNullOrWhiteSpace(n))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(n => n, StringComparer.OrdinalIgnoreCase)
                .ToList();

            _context = new ConfigFunctionEditingContext
            {
                AvailableVariables = availableVariables.Where(n => !string.IsNullOrWhiteSpace(n)).Distinct().OrderBy(n => n).ToList(),
                AvailableParameters = availableParameters.Where(n => !string.IsNullOrWhiteSpace(n)).Distinct().OrderBy(n => n).ToList(),
                AvailableFunctionNames = functionNames,
            };

            _root = BuildRootParameter(seedValue);

            editorHostPanel.Controls.Add(_editor);
            _editor.Changed += (_, _) => RefreshTree();
            _editor.ArgumentActivated += (_, child) => SelectNode(child);
            configFunctionTree.AfterSelect += ConfigFunctionTree_AfterSelect;

            RefreshTree();
        }

        /// <summary>
        /// Call after showing the dialog with DialogResult.OK to get the built value text. Both a
        /// literal string and a config function are, ultimately, a JSON string value, so both come
        /// back quoted (e.g. "hello" / "[variable('a')]") - matching exactly what BuildRootParameter
        /// expects back if the same text is fed in again as a seed. Quoting is done with
        /// EncodeStringLiteral rather than JsonSerializer.Serialize so the text isn't fully JSON-encoded
        /// (backslashes doubled, non-ASCII \u-escaped) - only the double quote needs escaping to keep
        /// the literal well-formed. Number/Boolean stay unquoted so StringExtensions.ParseConfigVariable
        /// reads them as an actual JSON number/bool, and Raw is the deliberate escape hatch that is
        /// always inserted verbatim, unquoted.
        /// </summary>
        public string GetResult() => _root.Type switch
        {
            "function" => _root.Value is ConfigFunctionModel model ? EncodeStringLiteral(model.ToBracketedConfigFunctionString()) : string.Empty,
            "string" => EncodeStringLiteral(_root.Value?.ToString() ?? string.Empty),
            _ => _root.Value?.ToString() ?? string.Empty,
        };

        /// <summary>Wraps a value as a quoted string literal, escaping only the double quote (the one
        /// character that would otherwise terminate the literal early) rather than JsonSerializer's full
        /// JSON escaping.</summary>
        private static string EncodeStringLiteral(string value) => "\"" + value.Replace("\"", "\\\"") + "\"";

        private static ConfigFunctionParameter BuildRootParameter(string? seedValue)
        {
            if (string.IsNullOrEmpty(seedValue))
            {
                return new ConfigFunctionParameter { Type = "string", Value = string.Empty };
            }

            // GetResult() always JSON-quotes what it hands back (see above); undo that one outer
            // layer of quoting before re-interpreting the seed, so re-opening a value built by this
            // dialog doesn't see literal quote characters as part of its own text.
            var unwrapped = UnwrapJsonStringLiteral(seedValue);

            var seeded = TryParseSeedAsFunction(unwrapped);
            if (seeded != null)
            {
                return new ConfigFunctionParameter { Type = "function", Value = seeded };
            }

            return new ConfigFunctionParameter { Type = "string", Value = unwrapped };
        }

        private static string UnwrapJsonStringLiteral(string seedValue)
        {
            var trimmed = seedValue.Trim();
            if (trimmed.Length < 2 || !trimmed.StartsWith('"') || !trimmed.EndsWith('"')) return seedValue;

            return trimmed.Substring(1, trimmed.Length - 2).Replace("\\\"", "\"");
        }

        private static ConfigFunctionModel? TryParseSeedAsFunction(string? seedValue)
        {
            if (string.IsNullOrWhiteSpace(seedValue)) return null;

            var trimmed = seedValue.Trim();
            var api = new ConfigFunctionApi();
            // ConfigFunctionApi expects the raw JSON-source text of the value (i.e. still quoted),
            // matching how ParseSifComponents encounters it when reading straight from the document.
            // ParseFunctionProcessor scans this text char-by-char for literal quote delimiters
            // without ever JSON-decoding it, so JsonSerializer.Serialize must not be used here -
            // its default encoder rewrites an apostrophe into the escape sequence backslash-u-0027,
            // which then can't be recognized as a string-literal delimiter (e.g. parameter('asd')
            // would come through with the literal escape sequence still in the parameter text).
            var quoted = EncodeStringLiteral(trimmed);

            if (!api.IsConfigFunction(quoted)) return null;

            var result = api.Parse(quoted).GetAwaiter().GetResult();
            if (result.HasError || result.Root is null) return null;
            if (!Expressions.IdentifierRegex.IsMatch(result.Root.Name)) return null;

            return result.Root;
        }

        private void ConfigFunctionTree_AfterSelect(object? sender, TreeViewEventArgs e)
        {
            _selected = e.Node?.Tag as ConfigFunctionParameter;
            LoadEditorIfSelectionChanged();
        }

        /// <summary>
        /// Only reloads the argument editor when the selected node actually changed. Reloading
        /// unconditionally (e.g. on every RefreshTree from a keystroke in the currently-open editor)
        /// tears down and rebuilds the editor's controls, which steals keyboard focus mid-typing.
        /// </summary>
        private void LoadEditorIfSelectionChanged()
        {
            if (_selected == null || ReferenceEquals(_selected, _loadedInEditor)) return;

            _loadedInEditor = _selected;
            _editor.LoadParameter(_selected, _context);
        }

        private void SelectNode(ConfigFunctionParameter target)
        {
            RefreshTree();
            var node = FindNode(configFunctionTree.Nodes, target);
            if (node != null)
            {
                configFunctionTree.SelectedNode = node;
                node.EnsureVisible();
            }
        }

        private static TreeNode? FindNode(TreeNodeCollection nodes, ConfigFunctionParameter target)
        {
            foreach (TreeNode node in nodes)
            {
                if (ReferenceEquals(node.Tag, target)) return node;
                var found = FindNode(node.Nodes, target);
                if (found != null) return found;
            }

            return null;
        }

        private void RefreshTree()
        {
            configFunctionTree.AfterSelect -= ConfigFunctionTree_AfterSelect;

            configFunctionTree.Nodes.Clear();
            var rootNode = BuildNode(_root);
            configFunctionTree.Nodes.Add(rootNode);
            rootNode.ExpandAll();

            var toSelect = _selected != null ? FindNode(configFunctionTree.Nodes, _selected) : null;
            configFunctionTree.SelectedNode = toSelect ?? rootNode;

            configFunctionTree.AfterSelect += ConfigFunctionTree_AfterSelect;

            _selected = configFunctionTree.SelectedNode?.Tag as ConfigFunctionParameter;
            LoadEditorIfSelectionChanged();
        }

        private static TreeNode BuildNode(ConfigFunctionParameter parameter)
        {
            var node = new TreeNode { Tag = parameter, Text = DescribeNode(parameter) };

            if (parameter.Type == "function" && parameter.Value is ConfigFunctionModel model)
            {
                foreach (var child in model.Parameters)
                {
                    node.Nodes.Add(BuildNode(child));
                }
            }

            return node;
        }

        private static string DescribeNode(ConfigFunctionParameter parameter)
        {
            var namePrefix = string.IsNullOrEmpty(parameter.Name) ? string.Empty : $"{parameter.Name}: ";

            if (parameter.Type == "function" && parameter.Value is ConfigFunctionModel model)
            {
                return $"{namePrefix}{(string.IsNullOrWhiteSpace(model.Name) ? "(unnamed)" : model.Name)}(...)";
            }

            try
            {
                return namePrefix + parameter.ToConfigFunctionValueText();
            }
            catch
            {
                return namePrefix + "(invalid)";
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            var invalid = FindInvalidFunctionName(_root);
            if (invalid != null)
            {
                MessageBox.Show(this, "Every function call needs a name before this can be saved.", "Build Expression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SelectNode(invalid);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private static ConfigFunctionParameter? FindInvalidFunctionName(ConfigFunctionParameter parameter)
        {
            if (parameter.Type == "function" && parameter.Value is ConfigFunctionModel model)
            {
                if (string.IsNullOrWhiteSpace(model.Name)) return parameter;

                foreach (var child in model.Parameters)
                {
                    var invalid = FindInvalidFunctionName(child);
                    if (invalid != null) return invalid;
                }
            }

            return null;
        }
    }
}
