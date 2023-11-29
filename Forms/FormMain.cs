// Version: 1.0.0.437
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Translator;
using WindowsSoftberyPlayer.ControlBar;
using WindowsSoftberyPlayer.Filters;

namespace WindowsSoftberyPlayer.Forms
{
    public partial class FormMain : Form
    {
        private const int WM_KEYDOWN = 0x0100;
        public delegate void delegateFullscreen(object sender, EventArgs e);
        public event delegateFullscreen OnFullScreen;
        private KeyPressFilter _keypressFilter;
        public bool isFullscreen { get; private set; } = false;

        /// <summary>
        /// Translation
        /// </summary>
        /// <example>
        /// translation.GetString("name");
        /// </example>
        private static ResourceManager _translation = new ResourceManager($"WindowsSoftberyPlayer.Languages.{Config.Parameters["Player"]["Language"]}", Assembly.GetExecutingAssembly());

        public FormMain()
        {
            InitializeComponent();
            
            _keypressFilter = new KeyPressFilter();
            _keypressFilter.KeyPressed += _keypressFilter_KeyPressed; ;
            Application.AddMessageFilter(_keypressFilter);

            /*var l = new Translator.Language();
            var s = "";
            foreach (var lang in l.LangList)
            {
                var la = lang.Lang().GetType();

                s += la.ToString() + Environment.NewLine;//la.ToString() + Environment.NewLine;
            }

            MessageBox.Show(s);*/

            videoControlBar1.Owner = this;
            ReadSubtile();
        }

        private void _keypressFilter_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                if (isFullscreen)
                {
                    fullscreenOff();
                }
            }
            if (e.KeyChar == (char)Keys.F5)
            {
                if (!isFullscreen)
                {
                    fullscreenOn();
                }
            }
            if (e.KeyChar == (char)Keys.F4 && Control.ModifierKeys == Keys.Alt)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void FormMain_OnFullScreen(object sender, EventArgs e)
        {
            if (OnFullScreen!=null)
            {
                if (isFullscreen)
                    isFullscreen = false;
                else
                    isFullscreen = true;

                OnFullScreen.Invoke(this, e);
            }
        }

        public void FullscreenOn()
        {
            fullscreenOn();
        }

        public void FullscreenOff()
        {
            fullscreenOff();
        }

        public void Fullscreen_OnOff()
        {
            if (isFullscreen)
            {
                fullscreenOff();

            }
            else
            {
                fullscreenOn();
            }
        }

        Form _fullscreen;

        private void fullscreenOff()
        {
            this.Controls.Add(videoControlBar1.GetVideoControlBar());
            
            _fullscreen.ShowInTaskbar = true;

            _fullscreen.Close();
            _fullscreen.Dispose();

            isFullscreen = false;
            Invalidate();
        }

        private void fullscreenOn()
        {
            _fullscreen = new Form();
            
            _fullscreen.WindowState = FormWindowState.Maximized;
            _fullscreen.FormBorderStyle = FormBorderStyle.None;
            _fullscreen.ShowInTaskbar = false;
            _fullscreen.Controls.Add(videoControlBar1);

            _fullscreen.Show();

            isFullscreen = true;
        }

        private void _fullscreen_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Show();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void ReadSubtile()
        {

        }
    }
}
