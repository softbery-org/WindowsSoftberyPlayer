// Version: 1.0.0.502
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsSoftberyPlayer.Filters
{
    public class MouseMoveFilter : IMessageFilter
    {
        public delegate void dlgMouseMove(object sender, MouseEventArgs e);
        public delegate void dlgMouseNotMove(object sender, EventArgs e);

        public event dlgMouseMove MouseMove;
        public event dlgMouseNotMove MouseNotMove;

        private Point lastPoint;
        private const int WM_MOUSEMOVE = 0x200;
        private System.Windows.Forms.Timer tmr;
        private int second = 5;
        
        public int Seconds { get => second; set => second = value; }

        public MouseMoveFilter()
        {
            tmr = new System.Windows.Forms.Timer();
            tmr.Enabled = false;
            tmr.Interval = (int)TimeSpan.FromSeconds(second).TotalMilliseconds;
            tmr.Tick += Tmr_Tick;
        }

        bool IMessageFilter.PreFilterMessage(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_MOUSEMOVE: // get phantom WM_MOUSEMOVE messages, when the mouse has NOT moved!
                    Point curPoint = Cursor.Position;
                    if (!curPoint.Equals(lastPoint))
                    {
                        lastPoint = curPoint;
                        if (MouseMove != null)
                        {
                            MouseEventArgs e = new MouseEventArgs(System.Windows.Forms.MouseButtons.Left, 1, 1, 1, 1);
                            MouseMove(this, e);
                        }
                        tmr.Stop();
                        tmr.Start();
                    }
                    break;
            }
            return false; // handle messages normally
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            tmr.Stop();
            if (MouseNotMove != null)
            {
                MouseNotMove(sender, e);
            }
        }


    }
}
