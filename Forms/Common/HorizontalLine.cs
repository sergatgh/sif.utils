using System;
using System.Collections.Generic;
using System.Text;

namespace SIF.Utils.Forms.Common
{
    public class HorizontalLine : Label
    {
        public override string Text => string.Empty;
        public override bool AutoSize => false;
        public override BorderStyle BorderStyle => BorderStyle.Fixed3D;
        public override Size MaximumSize => new Size(0, 2); // Limit the height to 2 pixels
        protected override Padding DefaultMargin => new Padding(0, 0, 0, 0);

        public HorizontalLine()
        {
            this.Width = 200; // Default width, can be adjusted as needed
        }
    }
}
