using System.ComponentModel;
using Microsoft.Web.Administration;
using SIF.Utils.Logic.AdminMode;

namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF
{
    public partial class AppPoolListControl : UserControl
    {
        private readonly IAdminModeApi _adminModeApi;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string TextLabel { get => labelText.Text; set => labelText.Text = value; }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string TextInput { get => appPoolCombo.Text; set => appPoolCombo.Text = value; }

        public AppPoolListControl() : this(new AdminModeApi())
        {
        }

        public AppPoolListControl(IAdminModeApi adminModeApi)
        {
            _adminModeApi = adminModeApi;
            InitializeComponent();

            if (!DesignMode)
            {
                LoadAppPools();
            }
        }

        private void LoadAppPools()
        {
            if (!_adminModeApi.IsRunningAsAdministrator())
            {
                ShowAdminSuggestion();
                return;
            }

            try
            {
                using var serverManager = new ServerManager();
                var names = serverManager.ApplicationPools
                    .Select(pool => pool.Name)
                    .OrderBy(name => name, StringComparer.OrdinalIgnoreCase)
                    .ToArray();

                appPoolCombo.Items.Clear();
                appPoolCombo.Items.AddRange(names);
            }
            catch (UnauthorizedAccessException)
            {
                ShowAdminSuggestion();
            }
        }

        private void ShowAdminSuggestion()
        {
            adminRequiredPanel.Visible = true;
        }

        private void restartLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _adminModeApi.RestartAsAdministrator();
        }
    }
}
