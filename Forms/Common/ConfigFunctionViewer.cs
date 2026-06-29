using SIF.Utils.Logic.ConfigFunctionParser;

namespace SIF.Utils
{
    public partial class ConfigFunctionViewer : Form
    {
        public ConfigFunctionViewer()
        {
            InitializeComponent();
        }

        public ConfigFunctionViewer(string configFunction) : this()
        {
            var result = new ConfigFunctionApi().Parse(configFunction).GetAwaiter().GetResult();
            LoadConfigFunction(result);
        }

        public void LoadConfigFunction(ConfigFunctionParsingResult parseResult)
        {
            configFunctionTree.Nodes.Clear();

            if (parseResult.HasError)
            {
                configFunctionTree.Visible = false;
                errorParsingConfigFunctionLabel.Visible = true;
                errorParsingConfigFunctionLabel.Text = parseResult.Error;
                return;
            }

            if (parseResult.Root == null)
            {
                configFunctionTree.Visible = false;
                errorParsingConfigFunctionLabel.Visible = true;
                return;
            }

            configFunctionTree.Nodes.Add(parseResult.Root.ToTreeNode());
            configFunctionTree.Nodes[0].ExpandAll();
        }
    }

    public static class ConfigFunctionExtensions
    {
        public static TreeNode ToTreeNode(this ConfigFunctionModel model)
        {
            var result = new TreeNode
            {
                Text = model.Name,
            };
            result.BackColor = Color.FromArgb(255, 255, 192);

            string accessorSuffix = model.Accessor.HasValue ? $"[{model.Accessor.Value}]" : string.Empty;

            if (model.Name == "parameter")
            {
                var param = model.Parameters.FirstOrDefault();
                if (param is { Type: "string" })
                {
                    result.Text += " - " + param.Value + accessorSuffix;
                    return result;
                }
            }

            if (model.Name == "variable")
            {
                var param = model.Parameters.SingleOrDefault();
                if (param is { Type: "string" })
                {
                    result.Text += " - " + param.Value + accessorSuffix;
                    return result;
                }
            }

            result.Text += accessorSuffix;
            result.Nodes.AddRange(model.Parameters.Select(x => x.ToTreeNode()).ToArray());

            if (model.Name == "if" && result.Nodes.Count == 3)
            {
                var trueNode = result.Nodes[1];
                var falseNode = result.Nodes[2];

                trueNode.Text = "(+) -> " + trueNode.Text;
                trueNode.BackColor = Color.FromArgb(192, 255, 192);

                falseNode.Text = "(-) -> " + falseNode.Text;
                falseNode.BackColor = Color.FromArgb(255, 224, 192);
            }

            return result;
        }

        public static TreeNode ToTreeNode(this ConfigFunctionParameter parameter)
        {
            string namePrefix = string.IsNullOrEmpty(parameter.Name) ? string.Empty : parameter.Name + ": ";

            if (parameter.Type == "function")
            {
                var node = ((ConfigFunctionModel)parameter.Value!).ToTreeNode();
                if (!string.IsNullOrEmpty(namePrefix))
                    node.Text = namePrefix + node.Text;
                return node;
            }

            var result = new TreeNode
            {
                Text = parameter.Value?.ToString() ?? string.Empty,
            };

            if (parameter.Type == "string")
            {
                result.BackColor = Color.FromArgb(192, 255, 255);
                result.Text = $"\"{result.Text}\"";
            }

            if (!string.IsNullOrEmpty(namePrefix))
                result.Text = namePrefix + result.Text;

            return result;
        }
    }
}
