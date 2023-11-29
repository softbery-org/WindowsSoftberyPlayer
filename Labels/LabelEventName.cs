// Version: 1.0.0.383
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsSoftberyPlayer.Labels
{
    public class LabelEventName : Label
    {
        public bool DrawFromRight { get; set; }
        public LabelEventName() : base()
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var gfx = e.Graphics;
            var brush = new SolidBrush(ForeColor);
            var pen = new Pen(brush);
            var str = Text;
            var sizef = e.Graphics.MeasureString(Text, Font);
            //Location = new Point((int)(ClientRectangle.Width - sizef.Width), 28);
            e.Graphics.DrawString(Text, Font, brush, -sizef.Width, 0);
            base.OnPaint(e);
        }
    }
}
