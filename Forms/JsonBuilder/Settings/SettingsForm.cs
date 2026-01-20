using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json.Nodes;
using System.Windows.Forms;

namespace SIF.Utils.Forms.JsonBuilder.Settings
{
    public partial class SettingsForm : UserControl
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        public void SetAutoRegisterExtensions(bool autoRegister)
        {
            this.autoRegisterExtensionsSetting.Checked = autoRegister;
        }

        public JsonObject GetJson()
        {
            var result = new JsonObject();

            if (this.autoRegisterExtensionsSetting.Checked)
            {
                result["AutoRegisterExtensions"] = this.autoRegisterExtensionsSetting.Checked;
            }

            if (!string.IsNullOrWhiteSpace(this.informationActionComboBox.Text))
            {
                result["InformationAction"] = this.informationActionComboBox.Text;
            }

            if (!string.IsNullOrWhiteSpace(this.warningActionCombobox.Text))
            {
                result["WarningAction"] = this.warningActionCombobox.Text;
            }

            if (!string.IsNullOrWhiteSpace(this.errorActionComboBox.Text))
            {
                result["ErrorAction"] = this.errorActionComboBox.Text;
            }

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            informationActionComboBox.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            warningActionCombobox.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            errorActionComboBox.Text = "";
        }
    }
}
