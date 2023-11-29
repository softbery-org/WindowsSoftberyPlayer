// Version: 1.0.0.278
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
        public int Transparency { get; set; } = 70;
        public LabelSubtiles() : base()
        {
            BackColor = Color.FromArgb(Transparency, BackColor);
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
            base.OnPaint(e);
        }
    }
}
