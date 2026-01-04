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
        public JsonViewer(string name, JsonElement property)
        {
            InitializeComponent();

            this.Text = $"Json Viewer - {name}";

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            var text = JsonSerializer.Serialize(property, options);

            textBox1.Text = text;
        }

        public JsonViewer(string name, string json)
        {
            InitializeComponent();

            this.Text = $"Json Viewer - {name}";

            textBox1.Text = json;
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
