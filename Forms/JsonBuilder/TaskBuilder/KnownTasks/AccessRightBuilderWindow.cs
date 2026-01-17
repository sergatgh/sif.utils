using System.Text.RegularExpressions;

namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks
{
    public partial class AccessRightBuilderWindow : Form
    {
        bool checkOperation = false;
        public AccessRightBuilderWindow()
        {
            InitializeComponent();
            inheritanceFlagsBox.SetItemChecked(0, true);
            accessRights.SetItemChecked(0, true);
        }

        private void inheritanceFlagsBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkOperation) return;

            if (sender is not CheckedListBox derList) return;

            checkOperation = true;

            if (e.Index == 0)
            {
                var noneSelected = e.NewValue == CheckState.Checked;
                propagationFlagsSelector.Enabled = !noneSelected;
                if (noneSelected)
                {
                    for (var i = 1; i < derList.Items.Count; i++)
                    {
                        derList.SetItemChecked(i, false);
                    }
                }
            }
            else
            {
                derList.SetItemChecked(0, false);
                propagationFlagsSelector.Enabled = true;
            }

            checkOperation = false;
        }

        private void propagationFlagsSelector_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkOperation) return;

            if (sender is not CheckedListBox derList) return;

            checkOperation = true;

            if (e.Index == 0)
            {
                var noneSelected = e.NewValue == CheckState.Checked;
                if (noneSelected)
                {
                    for (var i = 1; i < derList.Items.Count; i++)
                    {
                        derList.SetItemChecked(i, false);
                    }
                }
            }
            else
            {
                derList.SetItemChecked(0, false);
            }

            checkOperation = false;
        }

        public AccessRightSelection GetAccessRightSelection()
        {
            var inheritanceFlags = inheritanceFlagsBox.CheckedItems.Cast<string>().Select(x => Regex.Match(x, @"\((.*?)\)").Groups[1].Value).ToArray();
            var propagationFlags = !inheritanceFlags.Contains("None") ? propagationFlagsSelector.CheckedItems.Cast<string>().Select(x => Regex.Match(x, @"\((.*?)\)").Groups[1].Value).ToArray() : null;
            var accessFlags = accessRights.CheckedItems.Cast<string>().Select(x => x.Replace(" ", "")).ToArray();

            return new AccessRightSelection
            {
                User = userTextBox.TextInput,
                AccessRights = accessFlags,
                AccessControlType = allowAccessRadio.Checked ? "Allow" : "Deny",
                InheritanceFlags = inheritanceFlags.Length > 0 ? inheritanceFlags : null,
                PropagationFlags = propagationFlags?.Length > 0 ? propagationFlags : null,
            };
        }

        public void LoadAccessRight(AccessRightSelection accessRight)
        {
            userTextBox.TextInput = accessRight.User;
            allowAccessRadio.Checked = accessRight.AccessControlType == "Allow";
            denyAccessRadio.Checked = accessRight.AccessControlType == "Deny";
            for (var i = 0; i < accessRights.Items.Count; i++)
            {
                var item = accessRights.Items[i].ToString()!.Replace(" ", "");
                accessRights.SetItemChecked(i, accessRight.AccessRights.Contains(item));
            }
            if (accessRight.InheritanceFlags != null && accessRight.InheritanceFlags.Length > 0)
            {
                for (var i = 0; i < inheritanceFlagsBox.Items.Count; i++)
                {
                    var item = Regex.Match(inheritanceFlagsBox.Items[i].ToString()!, @"\((.*?)\)").Groups[1].Value;
                    inheritanceFlagsBox.SetItemChecked(i, accessRight.InheritanceFlags.Contains(item));
                }
            }
            if (accessRight.PropagationFlags is { Length: > 0 })
            {
                for (var i = 0; i < propagationFlagsSelector.Items.Count; i++)
                {
                    var item = Regex.Match(propagationFlagsSelector.Items[i].ToString()!, @"\((.*?)\)").Groups[1].Value;
                    propagationFlagsSelector.SetItemChecked(i, accessRight.PropagationFlags.Contains(item));
                }
            }
        }
    }
}
