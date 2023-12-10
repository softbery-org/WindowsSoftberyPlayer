// Version: 1.0.0.138
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsSoftberyPlayer.Ctrl
{
    public class LabelSubtiles : Control
    {
        public override Color BackColor { get; set; }
        public LabelSubtiles() : base()
        {
            //BackColor = Color.FromArgb(0, BackColor);
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Size = new Size(Width, Font.Height);
            var rectangle = new Rectangle(Location, Size);
            var brush = new SolidBrush(ForeColor);
            var pen = new Pen(brush, 1);
            var measure = TextRenderer.MeasureText(Text, Font);
            var location_width = (Parent.Width / 2) - (measure.Width/2);
            var location_height = 0;

            //TextRenderer.DrawText(e.Graphics, Text, Font, new Point(location_width, location_height), ForeColor, Color.Transparent, TextFormatFlags.HorizontalCenter);

            //e.Graphics.DrawRectangle(pen, rectangle);
            e.Graphics.Clear(BackColor);
            e.Graphics.DrawString(Text, Font, brush, location_width, location_height);

            base.OnPaint(e);
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            Refresh();
            base.OnForeColorChanged(e);
        }

        protected override void OnFontChanged(EventArgs e)
        {
            Refresh();
            base.OnFontChanged(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            Refresh();
            base.OnTextChanged(e);
        }
    }
}
