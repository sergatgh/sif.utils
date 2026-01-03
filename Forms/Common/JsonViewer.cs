using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIF.Utils
{
    using System.Text.Json;

    public partial class JsonViewer : Form
    {
        public JsonViewer(string name, JsonProperty property)
        {
            InitializeComponent();

            this.Text = $"Json Viewer - {name}";

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            var text = JsonSerializer.Serialize(property.Value, options);

            textBox1.Text = text;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true; // Indicate that the key has been handled
            }
            return base.ProcessDialogKey(keyData);
        }

        private void JsonViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
