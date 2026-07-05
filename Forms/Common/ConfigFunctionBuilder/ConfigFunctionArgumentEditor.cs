using SIF.Utils.Logic.ConfigFunctionParser;
using System.ComponentModel;

namespace SIF.Utils.Forms.Common.ConfigFunctionBuilder
{
    /// <summary>
    /// Editor for a single argument slot (or the whole root value) of a config function expression.
    /// Reused recursively: picking "Function call" turns the slot into a ConfigFunctionModel whose
    /// own arguments are edited by selecting them as separate nodes in the owning dialog's tree.
    /// </summary>
    public partial class ConfigFunctionArgumentEditor : UserControl
    {
        private enum EditorKind { Parameter, Variable, Function, Raw, LiteralString, Number, Boolean }

        [Browsable(true)]
        public event EventHandler? Changed;

        [Browsable(true)]
        public event EventHandler<ConfigFunctionParameter>? ArgumentActivated;

        private ConfigFunctionParameter? _parameter;
        private ConfigFunctionEditingContext? _context;
        private bool _loading;

        private Panel simpleValuePanel = null!;
        private TextBox valueTextBox = null!;
        private Panel booleanPanel = null!;
        private ComboBox booleanComboBox = null!;
        private Panel referencePanel = null!;
        private ComboBox referenceComboBox = null!;
        private Panel functionPanel = null!;
        private ComboBox functionNameComboBox = null!;
        private Button addArgumentButton = null!;
        private Panel argumentsScrollPanel = null!;
        private TableLayoutPanel argumentsTable = null!;

        public ConfigFunctionArgumentEditor()
        {
            InitializeComponent();
            BuildLayout();
        }

        public void LoadParameter(ConfigFunctionParameter parameter, ConfigFunctionEditingContext context)
        {
            _parameter = parameter;
            _context = context;
            _loading = true;
            try
            {
                var kind = DetermineKind(parameter);
                EnsureReferenceModel(kind, parameter);
                kindComboBox.SelectedIndex = (int)kind;
                ShowPanelFor(kind);
                PopulateControlsFor(kind, parameter);
            }
            finally
            {
                _loading = false;
            }
        }

        /// <summary>
        /// DetermineKind can report Parameter/Variable for an empty, not-yet-shaped parameter (e.g. a
        /// freshly added argument whose Type is still "string") purely to pick the default combo
        /// selection. PopulateReferenceCombo requires the parameter's Value to already be the nested
        /// ConfigFunctionModel that kind implies, so materialize it here before populating - otherwise
        /// the cast in PopulateReferenceCombo throws for what is still a plain string value.
        /// </summary>
        private static void EnsureReferenceModel(EditorKind kind, ConfigFunctionParameter parameter)
        {
            if (kind is not (EditorKind.Variable or EditorKind.Parameter) || parameter.Value is ConfigFunctionModel) return;

            parameter.Type = "function";
            parameter.Value = BuildReferenceModel(kind);
        }

        private void BuildLayout()
        {
            kindComboBox.Items.AddRange(["Parameter", "Variable", "Function call", "Raw / custom syntax", "Literal text", "Number", "Boolean"]);
            kindComboBox.SelectedIndexChanged += KindComboBox_SelectedIndexChanged;

            simpleValuePanel = new Panel { Dock = DockStyle.Fill };
            valueTextBox = new TextBox { Dock = DockStyle.Top };
            valueTextBox.TextChanged += ValueTextBox_TextChanged;
            simpleValuePanel.Controls.Add(valueTextBox);

            booleanPanel = new Panel { Dock = DockStyle.Fill };
            booleanComboBox = new ComboBox { Dock = DockStyle.Top, DropDownStyle = ComboBoxStyle.DropDownList };
            booleanComboBox.Items.AddRange(["True", "False"]);
            booleanComboBox.SelectedIndexChanged += BooleanComboBox_SelectedIndexChanged;
            booleanPanel.Controls.Add(booleanComboBox);

            referencePanel = new Panel { Dock = DockStyle.Fill };
            referenceComboBox = new ComboBox { Dock = DockStyle.Top, DropDownStyle = ComboBoxStyle.DropDown };
            referenceComboBox.TextChanged += ReferenceComboBox_TextChanged;
            referencePanel.Controls.Add(referenceComboBox);

            functionPanel = new Panel { Dock = DockStyle.Fill };
            argumentsTable = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                ColumnCount = 1,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
            };
            argumentsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            argumentsScrollPanel = new Panel { Dock = DockStyle.Fill, AutoScroll = true };
            argumentsScrollPanel.Controls.Add(argumentsTable);
            addArgumentButton = new Button { Dock = DockStyle.Top, Height = 34, Text = "+ Add argument" };
            addArgumentButton.Click += AddArgumentButton_Click;
            functionNameComboBox = new ComboBox { Dock = DockStyle.Top, DropDownStyle = ComboBoxStyle.DropDown };
            functionNameComboBox.SelectedIndexChanged += (_, _) => CommitFunctionName();
            functionNameComboBox.Leave += (_, _) => CommitFunctionName();
            functionPanel.Controls.Add(argumentsScrollPanel);
            functionPanel.Controls.Add(addArgumentButton);
            functionPanel.Controls.Add(functionNameComboBox);
        }

        private static ConfigFunctionModel BuildReferenceModel(EditorKind kind) => new()
        {
            Name = kind == EditorKind.Variable ? "variable" : "parameter",
            Parameters = [new ConfigFunctionParameter { Type = "string", Value = string.Empty }],
        };

        private static EditorKind DetermineKind(ConfigFunctionParameter parameter)
        {
            if (parameter.Type == "function" && parameter.Value is ConfigFunctionModel model)
            {
                if (string.Equals(model.Name, "variable", StringComparison.OrdinalIgnoreCase) && model.Parameters.Count <= 1)
                    return EditorKind.Variable;
                if (string.Equals(model.Name, "parameter", StringComparison.OrdinalIgnoreCase) && model.Parameters.Count <= 1)
                    return EditorKind.Parameter;
                return EditorKind.Function;
            }

            return parameter.Type switch
            {
                "number" => EditorKind.Number,
                "boolean" => EditorKind.Boolean,
                "raw" => EditorKind.Raw,
                _ when string.IsNullOrEmpty(parameter.Value?.ToString()) => EditorKind.Parameter,
                _ => EditorKind.LiteralString,
            };
        }

        private void ShowPanelFor(EditorKind kind)
        {
            valueContainerPanel.Controls.Clear();
            Control panel = kind switch
            {
                EditorKind.Boolean => booleanPanel,
                EditorKind.Variable or EditorKind.Parameter => referencePanel,
                EditorKind.Function => functionPanel,
                _ => simpleValuePanel,
            };
            panel.Dock = DockStyle.Fill;
            valueContainerPanel.Controls.Add(panel);
        }

        private void PopulateControlsFor(EditorKind kind, ConfigFunctionParameter parameter)
        {
            switch (kind)
            {
                case EditorKind.LiteralString:
                case EditorKind.Number:
                case EditorKind.Raw:
                    valueTextBox.Text = parameter.Value?.ToString() ?? string.Empty;
                    break;

                case EditorKind.Boolean:
                    booleanComboBox.SelectedIndex = parameter.Value is true ? 0 : 1;
                    break;

                case EditorKind.Variable:
                case EditorKind.Parameter:
                    PopulateReferenceCombo(kind, parameter);
                    break;

                case EditorKind.Function:
                    PopulateFunctionPanel(parameter);
                    break;
            }
        }

        private void PopulateReferenceCombo(EditorKind kind, ConfigFunctionParameter parameter)
        {
            var suggestions = kind == EditorKind.Variable ? _context!.AvailableVariables : _context!.AvailableParameters;

            var autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(suggestions.ToArray());
            referenceComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            referenceComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            referenceComboBox.AutoCompleteCustomSource = autoComplete;

            referenceComboBox.Items.Clear();
            referenceComboBox.Items.AddRange(suggestions.ToArray());

            var nested = (ConfigFunctionModel)parameter.Value!;
            var nameArgument = nested.Parameters.Count > 0 ? nested.Parameters[0] : null;

            // The name slot is still a tree node the user can reassign to any other kind (Number,
            // Boolean, Raw, Function call, ...). Editing it directly here only makes sense while it's
            // a literal string - for every other kind, show the rendered expression read-only (rather
            // than e.g. calling ToString() on a nested ConfigFunctionModel, which just prints the CLR
            // type name) until the user switches it back to "Literal text" via the tree.
            var isLiteral = nameArgument == null || nameArgument.Type == "string";
            referenceComboBox.Enabled = isLiteral;
            referenceComboBox.Text = isLiteral ? nameArgument?.Value?.ToString() ?? string.Empty : DescribeValue(nameArgument!);
        }

        private void PopulateFunctionPanel(ConfigFunctionParameter parameter)
        {
            functionNameComboBox.Items.Clear();
            functionNameComboBox.Items.AddRange(_context!.AvailableFunctionNames.ToArray());

            var model = (ConfigFunctionModel)parameter.Value!;
            functionNameComboBox.Text = model.Name;
            RebuildArgumentRows();
        }

        private void KindComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (_loading || _parameter == null) return;
            ApplyKind((EditorKind)kindComboBox.SelectedIndex);
        }

        private void ApplyKind(EditorKind kind)
        {
            var parameter = _parameter!;
            switch (kind)
            {
                case EditorKind.LiteralString:
                    parameter.Type = "string";
                    parameter.Value = string.Empty;
                    break;
                case EditorKind.Number:
                    parameter.Type = "number";
                    parameter.Value = "0";
                    break;
                case EditorKind.Boolean:
                    parameter.Type = "boolean";
                    parameter.Value = false;
                    break;
                case EditorKind.Variable:
                case EditorKind.Parameter:
                    parameter.Type = "function";
                    parameter.Value = BuildReferenceModel(kind);
                    break;
                case EditorKind.Function:
                    parameter.Type = "function";
                    parameter.Value = new ConfigFunctionModel { Name = string.Empty };
                    break;
                case EditorKind.Raw:
                    parameter.Type = "raw";
                    parameter.Value = string.Empty;
                    break;
            }

            _loading = true;
            try
            {
                ShowPanelFor(kind);
                PopulateControlsFor(kind, parameter);
            }
            finally
            {
                _loading = false;
            }

            RaiseChanged();
        }

        private void ValueTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (_loading || _parameter == null) return;
            _parameter.Value = valueTextBox.Text;
            RaiseChanged();
        }

        private void BooleanComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (_loading || _parameter == null) return;
            _parameter.Value = booleanComboBox.SelectedIndex == 0;
            RaiseChanged();
        }

        private void ReferenceComboBox_TextChanged(object? sender, EventArgs e)
        {
            if (_loading || _parameter?.Value is not ConfigFunctionModel nested) return;
            if (nested.Parameters.Count == 0)
                nested.Parameters.Add(new ConfigFunctionParameter { Type = "string", Value = string.Empty });

            // Normally unreachable while the name slot is a nested function (the combo is disabled -
            // see PopulateReferenceCombo), but guard it anyway: if text ever does get typed in here,
            // treat it as replacing the nested function with a literal name rather than leaving
            // Type == "function" paired with a string Value (which ToConfigFunctionValueText can't render).
            nested.Parameters[0].Type = "string";
            nested.Parameters[0].Value = referenceComboBox.Text;
            RaiseChanged();
        }

        private void CommitFunctionName()
        {
            if (_loading || _parameter?.Value is not ConfigFunctionModel model) return;

            var name = functionNameComboBox.Text.Trim();
            if (model.Name == name) return;
            model.Name = name;

            if (model.Parameters.Count == 0)
            {
                var definition = KnownConfigFunctions.Find(name);
                if (definition != null)
                {
                    foreach (var paramDef in definition.Parameters.Where(p => p.IsMandatory))
                    {
                        model.Parameters.Add(new ConfigFunctionParameter { Type = KindToType(paramDef.Kind), Value = DefaultValueFor(paramDef.Kind) });
                    }
                }
            }

            RebuildArgumentRows();
            RaiseChanged();
        }

        private static string KindToType(ConfigFunctionParamKind kind) => kind switch
        {
            ConfigFunctionParamKind.Number => "number",
            ConfigFunctionParamKind.Boolean => "boolean",
            _ => "string",
        };

        private static object DefaultValueFor(ConfigFunctionParamKind kind) => kind switch
        {
            ConfigFunctionParamKind.Number => "0",
            ConfigFunctionParamKind.Boolean => false,
            _ => string.Empty,
        };

        private void AddArgumentButton_Click(object? sender, EventArgs e)
        {
            if (_parameter?.Value is not ConfigFunctionModel model) return;
            model.Parameters.Add(new ConfigFunctionParameter { Type = "string", Value = string.Empty });
            RebuildArgumentRows();
            RaiseChanged();
        }

        private void RebuildArgumentRows()
        {
            argumentsTable.SuspendLayout();
            argumentsTable.Controls.Clear();
            argumentsTable.RowStyles.Clear();

            var children = _parameter?.Value is ConfigFunctionModel model ? model.Parameters.ToList() : [];
            argumentsTable.RowCount = children.Count;

            for (var i = 0; i < children.Count; i++)
            {
                argumentsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 36));
                argumentsTable.Controls.Add(BuildArgumentRow((ConfigFunctionModel)_parameter!.Value!, children[i]), 0, i);
            }

            argumentsTable.ResumeLayout(true);
        }

        private Control BuildArgumentRow(ConfigFunctionModel owner, ConfigFunctionParameter child)
        {
            var row = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 4,
                RowCount = 1,
                Margin = new Padding(0, 0, 0, 4),
            };
            row.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110));
            row.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            row.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80));
            row.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90));

            var nameTextBox = new TextBox { Dock = DockStyle.Fill, Text = child.Name ?? string.Empty, PlaceholderText = "(name)" };
            nameTextBox.TextChanged += (_, _) =>
            {
                child.Name = string.IsNullOrWhiteSpace(nameTextBox.Text) ? null : nameTextBox.Text.Trim();
                RaiseChanged();
            };

            var previewLabel = new Label { Dock = DockStyle.Fill, AutoEllipsis = true, TextAlign = ContentAlignment.MiddleLeft, Text = DescribeValue(child) };

            var editButton = new Button { Dock = DockStyle.Fill, Text = "Edit" };
            editButton.Click += (_, _) => ArgumentActivated?.Invoke(this, child);

            var removeButton = new Button { Dock = DockStyle.Fill, Text = "Remove" };
            removeButton.Click += (_, _) =>
            {
                owner.Parameters.Remove(child);
                RebuildArgumentRows();
                RaiseChanged();
            };

            row.Controls.Add(nameTextBox, 0, 0);
            row.Controls.Add(previewLabel, 1, 0);
            row.Controls.Add(editButton, 2, 0);
            row.Controls.Add(removeButton, 3, 0);
            return row;
        }

        private static string DescribeValue(ConfigFunctionParameter parameter)
        {
            try
            {
                return parameter.ToConfigFunctionValueText();
            }
            catch
            {
                return "(invalid)";
            }
        }

        private void RaiseChanged() => Changed?.Invoke(this, EventArgs.Empty);
    }
}
