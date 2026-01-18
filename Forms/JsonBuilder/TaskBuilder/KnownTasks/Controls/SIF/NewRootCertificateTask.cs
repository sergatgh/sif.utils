using SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF;
using System.Text.Json.Nodes;

namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    public partial class NewRootCertificateTask : AdvancedTask
    {
        public override TaskEditor TaskEditor => taskEditor1;

        public NewRootCertificateTask()
        {
            InitializeComponent();
        }

        public override Dictionary<string, JsonNode> GetAdditionalJsonProperties()
        {
            Dictionary<string, JsonNode> dict = new();

            if (!string.IsNullOrWhiteSpace(dnsNameText.TextInput))
            {
                dict["DnsName"] = dnsNameText.TextInput;
            }

            if (!string.IsNullOrWhiteSpace(storeLocation.Text))
            {
                dict["StoreLocation"] = storeLocation.Text.Replace(" ", "");
            }

            if (!string.IsNullOrWhiteSpace(friendlyName.TextInput))
            {
                dict["FriendlyName"] = friendlyName.TextInput;
            }

            if (!string.IsNullOrWhiteSpace(pathForCertificate.TextInput))
            {
                dict["Path"] = pathForCertificate.TextInput;
            }

            if (!string.IsNullOrWhiteSpace(fileName.TextInput))
            {
                dict["Name"] = fileName.TextInput;
            }

            if (!string.IsNullOrWhiteSpace(passwordText.TextInput))
            {
                dict["Password"] = passwordText.TextInput;
            }

            if (IncludePrivateKey.Checked)
            {
                dict["IncludePrivateKey"] = IncludePrivateKey.Checked;
            }

            return dict;
        }
    }
}
