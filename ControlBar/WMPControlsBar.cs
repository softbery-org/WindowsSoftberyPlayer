// Version: 1.0.0.167
using AxWMPLib;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WMPLib;

namespace WindowsSoftberyPlayer.ControlBar
{
    /// <summary>
    /// 
    /// </summary>
    public partial class WMPControlsBar : UserControl
    {
        private int _volume = 0;
        private bool _muted = false;
        private System.Windows.Forms.Timer _timer;
        private string _videoName; 
        private Filters.MouseMoveFilter _mouseMoveFilter;
        private const int WM_MOUSEMOVE = 0x200;
        private AxWindowsMediaPlayer _player;
        private WMPPlayState _playState;

        /// <summary>
        /// 
        /// </summary>
        public event FullscreenEventHandler FullscreenChange;
        
        /// <summary>
        /// 
        /// </summary>
        public WMPControlsBar()
        {
            InitializeComponent();

            // Mouse 5 second time wait and hide panel
            _mouseMoveFilter = new Filters.MouseMoveFilter();
            _mouseMoveFilter.MouseMove += _mouseMoveFilter_MouseMoved;
            _mouseMoveFilter.MouseNotMove += _mouseMoveFilter_SecondWithoutMouseMove;
            Application.AddMessageFilter(_mouseMoveFilter);

            _player = axWMP;
            axWMP.uiMode = "none";

            _timer = new System.Windows.Forms.Timer();
            _timer.Tick += _timer_Tick;

            FullscreenChange += onFullscreenEvent;   
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (_player.fullScreen)
            {
                panelControl.Show();
            }
        }

        private Form fullScreenForm;
        private bool _isFullScreen = false;

        private void ShowFullScreen()
        {
            var form = new Form();
            if (!_isFullScreen)
            {
                //WindowsTaskbar.Hide();
                /*foreach (var item in this.ParentForm.Controls)
                {
                    if (item.GetType() == typeof(MenuStrip))
                    {
                        var menu = item as MenuStrip;
                        menu.Hide();
                    }
                    if (item.GetType() == typeof(StatusStrip))
                    {
                        var status = item as StatusStrip;
                        status.Hide();
                    }
                }*/

                //this.Location = new Point(0, 0);
                //this.Size = this.ParentForm.Size;

                form.FormBorderStyle = FormBorderStyle.None;
                form.WindowState = FormWindowState.Maximized;
                form.ShowInTaskbar = false;
                
                _isFullScreen = true;
            }
            else
            {
                //WindowsTaskbar.Show();

                /*var menu_size = new Size();
                var status_bar_size = new Size();

                foreach (var item in this.ParentForm.Controls)
                {
                    if (item.GetType() == typeof(MenuStrip))
                    {
                        var menu = item as MenuStrip;
                        menu.Show();
                        menu_size = menu.Size;
                    }
                    if (item.GetType() == typeof(StatusStrip))
                    {
                        var status = item as StatusStrip;
                        status.Show();
                        status_bar_size = status.Size;
                    }
                }
                this.Size = new Size(this.Width, this.Height - (menu_size.Height + status_bar_size.Height));
                this.Location = new Point(0, menu_size.Height);*/

                form.FormBorderStyle = FormBorderStyle.Sizable;
                form.WindowState = FormWindowState.Normal;
                form.ShowInTaskbar = true;

                _isFullScreen = false;
            }
            /*
            if (fullScreenForm == null)
            {
                fullScreenForm = new Form();
                fullScreenForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                fullScreenForm.WindowState = FormWindowState.Maximized;
                fullScreenForm.ShowInTaskbar = false;
                this.Dock = DockStyle.Fill;
                fullScreenForm.Controls.Add(this);
                fullScreenForm.Show();
                _isFullScreen = true;
            }
            else
            {
                fullScreenForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                fullScreenForm.WindowState = FormWindowState.Normal;
                fullScreenForm.ShowInTaskbar = true;
                this.Dock = DockStyle.Fill;
                fullScreenForm.Dispose();
                fullScreenForm.Close();
                fullScreenForm.Dispose();
                _isFullScreen = false;
            }
            */
        }

        private double _maxTime;
        private double _currentTime;

        private void _timer_Tick(object sender, EventArgs e)
        {
            if (_player != null)
            {
                _maxTime = _player.currentMedia.duration;
                _currentTime = _player.Ctlcontrols.currentPosition;

                colorSliderTrackBar.Maximum = (decimal)_maxTime;
                colorSliderTrackBar.Value = (decimal)_currentTime;

                this.Text = string.Format("{0}", _videoName)
                    + " : " +
                    string.Format("{0:00}:{1:00}:{2:00}", _currentTime / 3600, (_currentTime / 60) % 60, _currentTime % 60)
                    + " / " +
                    string.Format("{0:00}:{1:00}:{2:00}", _maxTime / 3600, (_maxTime / 60) % 60, _maxTime % 60);
                labelCurrentTime.Text = string.Format("{0:00}:{1:00}:{2:00}", _currentTime / 3600, (_currentTime / 60) % 60, _currentTime % 60);
                labelDurationTime.Text = string.Format("{0:00}:{1:00}:{2:00}", _maxTime / 3600, (_maxTime / 60) % 60, _maxTime % 60);
                labelCurrentTime.Text = string.Format("{0:00}:{1:00}:{2:00}", _currentTime / 3600, (_currentTime / 60) % 60, _currentTime % 60);
                //labelCurrentVolume.Text = Convert.ToInt32(Player.currentMedia.Audio.Volume).ToString();
                labelVideoName.Text = _videoName;
            }
        }

        private void pbFullscreen_MouseHover(object sender, EventArgs e)
        {
            pbFullscreen.Image = Properties.Resources.fullscreen_hover;
        }

        private void pbForward_MouseHover(object sender, EventArgs e)
        {
            pbForward.Image = Properties.Resources.forward;
        }

        private void pbOpen_MouseHover(object sender, EventArgs e)
        {
            pbOpen.Image = Properties.Resources.open_hover;
        }

        private void pbStop_MouseHover(object sender, EventArgs e)
        {
            pbStop.Image = Properties.Resources.stop_hover;
        }

        private void pbPlay_MouseHover(object sender, EventArgs e)
        {
            pbPlay.Image = Properties.Resources.play_hover;
        }

        private void pbRewind_MouseHover(object sender, EventArgs e)
        {
            pbRewind.Image = Properties.Resources.rewind;
        }

        private void pbMute_MouseHover(object sender, EventArgs e)
        {
            pbMute.Image = Properties.Resources.mute;
        }

        private void pbVolumeDown_MouseHover(object sender, EventArgs e)
        {
            pbVolumeDown.Image = Properties.Resources.low_volume;
        }

        private void pbVolumeUp_MouseHover(object sender, EventArgs e)
        {
            pbVolumeUp.Image = Properties.Resources.audio;
        }

        private void pbSettings_MouseHover(object sender, EventArgs e)
        {
            pbSettings.Image = Properties.Resources.settings_hover;
        }

        private void pbPlay_Click(object sender, EventArgs e)
        {
            if (_player != null)
            {
                if (_player.playState.HasFlag(WMPPlayState.wmppsPlaying))
                {
                    _player.Ctlcontrols.pause();
                    _timer.Enabled = false;
                }
                else
                {
                    _player.Ctlcontrols.play();
                    _timer.Enabled = true;
                }
            }
        }

        private void pbStop_Click(object sender, EventArgs e)
        {
            if (_player != null)
            {
                _player.Ctlcontrols.stop();
            }
        }

        private void pbMute_Click(object sender, EventArgs e)
        {
            if (_player != null)
            {
                if (_player.settings.mute)
                    _player.settings.mute = false;
                else
                    _player.settings.mute = true;
            }
        }

        private void pbVolumeDown_Click(object sender, EventArgs e)
        {
            if (_player != null)
            {
                _player.settings.volume--;
            }
        }

        private void pbVolumeUp_Click(object sender, EventArgs e)
        {
            if (_player != null)
            {
                _player.settings.volume++;
            }
        }

        private void pbOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Video files (*.avi,*.mp4,*.mkv,*.wmv,*.mpg,*.mpeg,*.mp3)|(*.avi,*.mp4,*.mkv,*.wmv,*.mpg,*.mpeg,*.mp3)|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var video_file = ofd.FileName;
                var dir = new FileInfo(video_file).Directory.FullName;
                _videoName = video_file.Replace(dir + "\\", String.Empty);
                try
                {
                    Clear();
                    _player.URL = ofd.FileName;
                    _player.PlayStateChange += Player_PlayStateChange;
                    _timer.Enabled = true;
                    _currentTime = Convert.ToDouble(_player.Ctlcontrols.currentPosition);
                    _maxTime = Convert.ToDouble(_player.currentMedia.duration);
                    //Logger.Net48.Logger.Write(this, new Log() { LogType = LogType.Info, Message = $"Opening video file: {video_file}", SenderType = Logger.Net48.Logger.GetMethodName() });
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[{ex.HResult}]: {ex.Message}");
                }
            }
        }

        private void Player_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            switch (_playState)
            {
                case WMPPlayState.wmppsUndefined:
                    break;
                case WMPPlayState.wmppsStopped:
                    break;
                case WMPPlayState.wmppsPaused:
                    break;
                case WMPPlayState.wmppsPlaying:
                    break;
                case WMPPlayState.wmppsScanForward:
                    break;
                case WMPPlayState.wmppsScanReverse:
                    break;
                case WMPPlayState.wmppsBuffering:
                    break;
                case WMPPlayState.wmppsWaiting:
                    break;
                case WMPPlayState.wmppsMediaEnded:
                    break;
                case WMPPlayState.wmppsTransitioning:
                    break;
                case WMPPlayState.wmppsReady:
                    break;
                case WMPPlayState.wmppsReconnecting:
                    break;
                case WMPPlayState.wmppsLast:
                    break;
                default:
                    break;
            }
        }

        private void Clear()
        {
            if (_player != null)
            {
                _player.URL = null;
                _timer.Enabled = false;
            }
        }

        private void _video_Ending(object sender, EventArgs e)
        {
            _player.Dispose();
        }

        private void pbForward_Click(object sender, EventArgs e)
        {

        }

        private void pbFullscreen_Click(object sender, EventArgs e)
        {
            if (_player != null)
            {
                if (!_player.fullScreen)
                {
                    _player.fullScreen = true;
                    //var ctrl = this;
                    //ctrl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                    //_player.Controls.Add(ctrl);
                }
                else
                {
                    _player.fullScreen = false;
                }
            }
        }

        private void pbSettings_Click(object sender, EventArgs e)
        {
            Forms.FormSettings form = new Forms.FormSettings();
            form.Show();
        }

        private void pbRewind_Click(object sender, EventArgs e)
        {
            
        }

        private void pbFullscreen_MouseLeave(object sender, EventArgs e)
        {
            pbFullscreen.Image = Properties.Resources.fullscreen;
        }

        private void pbForward_MouseLeave(object sender, EventArgs e)
        {
            pbForward.Image = Properties.Resources.forward;
        }

        private void pbOpen_MouseLeave(object sender, EventArgs e)
        {
            pbOpen.Image = Properties.Resources.open;
        }

        private void pbSettings_MouseLeave(object sender, EventArgs e)
        {
            pbSettings.Image = Properties.Resources.settings;
        }

        private void pbMute_MouseLeave(object sender, EventArgs e)
        {
            pbMute.Image = Properties.Resources.mute;
        }

        private void pbVolumeDown_MouseLeave(object sender, EventArgs e)
        {
            pbVolumeDown.Image = Properties.Resources.low_volume;
        }

        private void pbVolumeUp_MouseLeave(object sender, EventArgs e)
        {
            pbVolumeUp.Image = Properties.Resources.audio;
        }

        private void pbStop_MouseLeave(object sender, EventArgs e)
        {
            pbStop.Image = Properties.Resources.stop;
        }

        private void pbPlay_MouseLeave(object sender, EventArgs e)
        {
            pbPlay.Image = Properties.Resources.play;
        }

        private void pbRewind_MouseLeave(object sender, EventArgs e)
        {
            pbRewind.Image = Properties.Resources.rewind;
        }

        private void colorSliderTrackBar_Click(object sender, EventArgs e)
        {
            
        }

        private void colorSliderTrackBar_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void colorSliderTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (_player != null)
            {
                _player.Ctlcontrols.currentPosition = (double)e.NewValue;
            }
        }

        private void jumpToPosition(double position)
        {
            _timer.Enabled = false;
            _player.Ctlcontrols.currentPosition = position;
            colorSliderTrackBar.Value = (decimal)position;
            _timer.Enabled = true;
        }

        private void onFullscreenEvent(object sender, FullscreenEventArgs e)
        {
            if (FullscreenChange != null)
            {
                var obj = sender as AxWindowsMediaPlayer;
                var fea = new FullscreenEventArgs(obj.fullScreen);
                FullscreenChange?.Invoke(obj, fea);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool isFullscreen()
        {
            return _player.fullScreen;
        }

        #region Mouse moving and waiting for move
        /// <summary>
        /// 
        /// </summary>
        private void _mouseMoveFilter_SecondWithoutMouseMove(object sender, EventArgs e)
        {
            panelControl.Hide();
            if (_player != null && _player.fullScreen)
            {
                Cursor.Hide();
            }    
        }

        /// <summary>
        /// 
        /// </summary>
        private void _mouseMoveFilter_MouseMoved(object sender, MouseEventArgs e)
        {
            panelControl.Show();
            if (_player != null && _player.fullScreen)
                Cursor.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            // Listen for operating system messages
            switch (m.Msg)
            {
                case WM_MOUSEMOVE:
                    this.MouseMove += WMPControlsBar_MouseMove;
                    break;
            }
            base.WndProc(ref m);
        }
        
        private void WMPControlsBar_MouseMove(object sender, MouseEventArgs e)
        {
            // if mouse moving do this
        }
        #endregion
    }

    /// <summary>
    /// 
    /// </summary>
    public class WindowsTaskbar
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="className"></param>
        /// <param name="windowText"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        private static extern int FindWindow(string className, string windowText);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hwnd"></param>
        /// <param name="command"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        private static extern int ShowWindow(int hwnd, int command);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parentHandle"></param>
        /// <param name="childAfter"></param>
        /// <param name="className"></param>
        /// <param name="windowTitle"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern int FindWindowEx(int parentHandle, int childAfter, string className, int windowTitle);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [DllImport("user32.dll")]
        private static extern int GetDesktopWindow();

        private const int SW_HIDE = 0;
        private const int SW_SHOW = 1;

        /// <summary>
        /// 
        /// </summary>
        protected static int Handle
        {
            get
            {
                return FindWindow("Shell_TrayWnd", "");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        protected static int HandleOfStartButton
        {
            get
            {
                int handleOfDesktop = GetDesktopWindow();
                int handleOfStartButton = FindWindowEx(handleOfDesktop, 0, "button", 0);
                return handleOfStartButton;
            }
        }

        private WindowsTaskbar()
        {
            // hide ctor
        }

        /// <summary>
        /// 
        /// </summary>
        public static void Show()
        {
            ShowWindow(Handle, SW_SHOW);
            ShowWindow(HandleOfStartButton, SW_SHOW);
        }

        /// <summary>
        /// 
        /// </summary>
        public static void Hide()
        {
            ShowWindow(Handle, SW_HIDE);
            ShowWindow(HandleOfStartButton, SW_HIDE);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void FullscreenEventHandler(object sender, FullscreenEventArgs e);

    /// <summary>
    /// 
    /// </summary>
    public class FullscreenEventArgs : EventArgs
    {
        /// <summary>
        /// 
        /// </summary>
        public bool isFullscreen { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public FullscreenEventArgs(bool fullscreen)
        {
            isFullscreen = fullscreen;
        }
    }
}
