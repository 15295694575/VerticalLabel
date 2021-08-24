using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerticalLabel
{
    public partial class CustomVerticalLabel : Control
    {
        private string _verticalLabelText = "Label";

        public string VerticalLabelText
        {
            get { return _verticalLabelText; }
            set
            {
                _verticalLabelText = value;
                Refresh();
            }
        } 

        public CustomVerticalLabel()
        {
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            if (string.IsNullOrEmpty(this.VerticalLabelText.Trim())) return;

            // Rotation-90.
            Graphics g = pe.Graphics;
            g.RotateTransform(-90);

            // Calculate Offset.
            int txtWidth = (int)g.MeasureString(this.VerticalLabelText.Substring(0, 1), this.Font).Height;
            int txtHeight = (int)g.MeasureString(this.VerticalLabelText, this.Font, Text.Length, new StringFormat(StringFormatFlags.DirectionVertical)).Height;
            int xOffset = -(this.Height + txtHeight) / 2;
            int yOffset = (this.Width - txtWidth) / 2;

            // Redrawn.
            using (SolidBrush brush = new SolidBrush(this.ForeColor))
            {
                g.DrawString(this.VerticalLabelText, this.Font, brush, xOffset, yOffset);
            }
        }
    }
}
