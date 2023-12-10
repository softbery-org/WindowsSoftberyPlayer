// Version: 1.0.0.440
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsSoftberyPlayer.Labels
{
    public class LabelSubtiles : Label
    {
        public delegate void dlgColorTransparencyChange(object sender, EventArgs e);
        public event dlgColorTransparencyChange TransparencyChange;
        public int Transparency { get; set; } = 0;
        public LabelSubtiles() : base()
        {
            BackColor = Color.FromArgb(Transparency, BackColor);
            DoubleBuffered = true;
        }

        public LabelSubtiles(Control owner) : this()
        {
            Parent = owner;
            Width = Parent.Width;
            Height = Font.Height;
        }

        protected virtual void OnTransparencyChange(object sender, EventArgs e)
        {
            if (TransparencyChange!=null)
            {
                BackColor = Color.FromArgb(Transparency, BackColor);
                TransparencyChange.Invoke(this, e);
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var brush = new SolidBrush(ForeColor);
            var pen = new Pen(brush, 1);
            var measure = TextRenderer.MeasureText(Text, Font);
            var location_width = (Parent.Width / 2) - (measure.Width / 2);
           // var location_height = 0;
            Location = new Point(location_width, Location.Y);
            //e.Graphics.DrawString(Text, Font, brush, location_width, location_height);
            base.OnPaint(e);
        }
    }
}
