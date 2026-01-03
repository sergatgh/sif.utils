using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIF.Utils.Forms.JsonBuilder
{
    public partial class LabeledTextbox : UserControl
    {
        private bool vertical;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string TextLabel { get => label1.Text; set => label1.Text = value; }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string TextInput { get => textBox1.Text; set => textBox1.Text = value; }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool Vertical
        {
            get => vertical;
            set
            {
                vertical = value;
                label1.Dock = value ? DockStyle.Top : DockStyle.Left;
            }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool Multiline
        {
            get => textBox1.Multiline;
            set
            {
                textBox1.Multiline = value;
                if (value)
                {
                    textBox1.Height = 60;
                }
            }
        }

        [Browsable(true)]
        public event EventHandler? TextChanged
        {
            add => textBox1.TextChanged += value;
            remove => textBox1.TextChanged -= value;
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public new event KeyEventHandler? KeyDown
        {
            add => textBox1.KeyDown += value;
            remove => textBox1.KeyDown -= value;
        }

        public LabeledTextbox()
        {
            InitializeComponent();
        }
    }
}
