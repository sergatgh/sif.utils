using System.ComponentModel;

namespace SIF.Utils.Forms.JsonBuilder
{
    public partial class Expander : UserControl
    {
        int initialHeight;
        int upperPanelHeight = 50;

        public Expander()
        {
            InitializeComponent();
            initialHeight = splitContainer1.Height;
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string PanelText { get => this.checkBox1.Text; set => this.checkBox1.Text = value; }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool Collapsed
        {
            get => splitContainer1.Panel2Collapsed;
            set
            {
                splitContainer1.Panel2Collapsed = value;
                Height = value ? upperPanelHeight : initialHeight;
                checkBox1.Checked = !value;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = !checkBox1.Checked;

            Height = checkBox1.Checked ? initialHeight : upperPanelHeight;
        }
    }
}
