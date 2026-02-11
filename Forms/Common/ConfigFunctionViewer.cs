using SIF.Utils.Logic.ConfigFunctionParser;

namespace SIF.Utils
{
    public partial class ConfigFunctionViewer : Form
    {
        private readonly string _configFunction;

        public ConfigFunctionViewer(string configFunction)
        {
            _configFunction = configFunction;
            InitializeComponent();
        }

        private async void ConfigFunctionViewer_Load(object sender, EventArgs e)
        {
            configFunctionTree.Nodes.Clear();
            var parseResult = await new ConfigFunctionApi().Parse(_configFunction);

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

            if (model.Name == "parameter")
            {
                var param = model.Parameters.FirstOrDefault();
                if (param is { Type: "string" })
                {
                    result.Text += " - " + param.Value;
                    return result;
                }
            }

            if (model.Name == "variable")
            {
                var param = model.Parameters.SingleOrDefault();
                if (param is { Type: "string" })
                {
                    result.Text += " - " + param.Value;
                    return result;
                }
            }

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
            if (parameter.Type == "function")
            {
                return ((ConfigFunctionModel)parameter.Value!).ToTreeNode();
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

            return result;
        }
    }
}
