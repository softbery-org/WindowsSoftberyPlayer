// Version: 1.0.0.495
using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsSoftberyPlayer.Filters;
using WindowsSoftberyPlayer.Forms;
using WindowsSoftberyPlayer.Labels;
using WindowsSoftberyPlayer.Panels;
using WMPLib;
using WSPSubtile;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static WindowsSoftberyPlayer.ControlBar.VideoControlBar;

namespace WindowsSoftberyPlayer.ControlBar
{
    public partial class VideoControlBar : UserControl
    {
        /// <summary>
        /// Translation
        /// </summary>
        /// <example>
        /// translation.GetString("name");
        /// </example>
        //private static ResourceManager translation = new ResourceManager($"WindowsSoftberyPlayer.Languages.{Config.Parameters["Player"]["Language"]}", Assembly.GetExecutingAssembly());

        private bool _fullscreen = false;
        private int _volume = 0;
        private bool _muted = false;
        private System.Windows.Forms.Timer _timer;
        private string _videoName;
        private Filters.MouseMoveFilter _mouseMoveFilter;
        private Filters.KeyPressFilter _keypressFilter;
        private const int WM_MOUSEMOVE = 0x200;
        private const int WM_KEYDOWN = 0x0100;
        private const int VK_ESCAPE = 27;
        private AxWindowsMediaPlayer _player;
        private WMPPlayState _playState;
        private double _maxTime;
        private double _currentTime;
        private Task _eventName;

        public delegate Task dlgShowEventLabel(string txt);
        public event dlgShowEventLabel ShowEventLabel;
        public object Owner { get; set; } = null;
        public bool WidgetTime { get; set; } = true;
        private string _subtilesFile;
        public enum TextLocationType
        {
            LeftTop,
            RightTop,
            CenterTop,
            LeftMiddle,
            RightMiddle,
            CenterMiddle,
            LeftBottom,
            RightBottom,
            CenterBottom
        }
        public delegate void dlgTextLocation(object sender, TextLocationEventArgs e);
        public event dlgTextLocation ShowTextLocation;
        public event dlgTextLocation ChangeTextLocation;
        public int Opacity { get; set; } = 100;
        public Color OpacityColor { get; set; }
        /// <summary>
        /// Default 10 sec
        /// </summary>
        public int SeekTime { get; set; } = 10;
        public string SubtilesFile { get; private set; }
        public bool ShowSubtiles { get; set; } = false;
        public TimeWidget TimeWidgetValue { get; set; } = TimeWidget.Left;
        private Dictionary<string, Subtile> _sub;
        private SubtileManager _manager = new SubtileManager();
        //private List<SubtileSrt> _list = new List<SubtileSrt>();

        private void OnShowTextLocation(object sender, TextLocationEventArgs e)
        {
            if (ShowTextLocation!=null)
            {
                ShowTextLocation.Invoke(this, e);
            }
        }

        private void RefreshControl(string name)
        {
            this.ChangeLanguage(name);
            translate();
            Refresh();
        }

        private async void translate()
        {
            labelSubtilesOnOffText.Text = Language.Translation.videoControlBar_labelSubtilesOnOffText;
            if (ShowSubtiles)
            {
                labelOnOff.Text = Language.Translation.videoControlBar_labelOff;
                labelOnOff.ForeColor = Color.FromArgb(255, 0, 0);
                await drawEventName(Language.Translation.videoControlBar_subtilesOff);
            }
            else
            {
                labelOnOff.Text = Language.Translation.videoControlBar_labelOn;
                labelOnOff.ForeColor = Color.FromArgb(0, 255, 0);
                await ShowEventLabel(Language.Translation.videoControlBar_subtilesOn);
            }
        }

        public VideoControlBar() : base()
        {
            InitializeComponent();
            _mouseMoveFilter = new Filters.MouseMoveFilter();
            _mouseMoveFilter.MouseMove += _mouseMoveFilter_OnMouseMove;
            _mouseMoveFilter.MouseNotMove += _mouseMoveFilter_OnMouseNotMove;
            System.Windows.Forms.Application.AddMessageFilter(_mouseMoveFilter);

            _keypressFilter = new KeyPressFilter();
            _keypressFilter.KeyPressed += _keypressFilter_KeyPressed;
            System.Windows.Forms.Application.AddMessageFilter(_keypressFilter);

            _player = axWMP;
            _player.stretchToFit = true;
            axWMP.uiMode = "none";

            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 100;
            _timer.Tick += _timer_Tick;


            _sub = new Dictionary<string, Subtile>();

            if (Owner == null)
                Owner = this.ParentForm as FormMain;

            panelControl.BringToFront();
            
            // When settings language are change then refresh control
            SettingsLanguage.OnLanguageChange += RefreshControl;
            labelRunedEvent.Visible = false;
            ShowEventLabel += drawEventName;
            
            translate();
            showHideSubtiles();
            
            Invalidate();
        }

        private async Task drawEventName(string txt)
        {
            await Task.Run(async()=>
            {
                labelRunedEvent.Invoke((MethodInvoker)(() =>
                {
                    labelRunedEvent.Visible = true;
                    labelRunedEvent.Text = txt;
                    labelRunedEvent.Location = new Point((int)(this.Width - labelRunedEvent.Width), 28);
                }));
                
                await Task.Delay(SeekTime * 1000);

                if (Task.CompletedTask.IsCompleted)
                {
                    labelRunedEvent.Invoke((MethodInvoker)(() =>
                    {
                        labelRunedEvent.Visible = false;
                    }));
                }
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _keypressFilter_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (_player != null)
            {
                if (e.KeyChar == (char)Keys.Left)
                {
                    if (_player.Ctlcontrols.currentPosition >= 0)
                        _player.Ctlcontrols.currentPosition -= SeekTime;
                    else
                        _player.Ctlcontrols.currentPosition = 0;
                }
                if (e.KeyChar == (char)Keys.Right)
                {
                    if (_player.Ctlcontrols.currentPosition <= _player.currentMedia.duration)
                        _player.Ctlcontrols.currentPosition += SeekTime;
                    else
                        _player.Ctlcontrols.currentPosition = _player.currentMedia.duration;
                }
            }
        }

        public VideoControlBar(object owner) : this()
        {
            var o = owner as FormMain;
            Owner = o;
        }

        public VideoControlBar GetVideoControlBar()
        {
            return this;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        #region FullScreen
        /// <summary>
        /// If fullscreen is on this set window to normal and if fullscreen is normal set window to full screen
        /// </summary>
        private async void FullScreen()
        {
            if (_player != null)
            {
                if (!_fullscreen)
                {
                    var f = Owner as FormMain;
                    f.FullscreenOn();

                    _fullscreen = true;

                    await drawEventName(Language.Translation.videoControlBar_fullscreenOn);
                }
                else
                {
                    var f = Owner as FormMain;
                    f.FullscreenOff();

                    _fullscreen = false;
                    await drawEventName(Language.Translation.videoControlBar_fullscreenOff);
                }
            }
        }
        #endregion

        #region Timer
        private int _subint = 0;
        private void _timer_Tick(object sender, EventArgs e)
        {
            if (_player != null)
            {
                _maxTime = _player.currentMedia.duration;
                _currentTime = _player.Ctlcontrols.currentPosition;

                colorSliderTrackBar.Maximum = (decimal)_maxTime;
                colorSliderTrackBar.Value = (decimal)_currentTime;

                var ts = GetTimeSpan(_maxTime);
                var tse = GetTimeSpan(_currentTime);
                var tsl = GetTimeSpan(_maxTime - _currentTime);

                var elapsed_time = $"{tse.Hours:00}:{tse.Minutes:00}:{tse.Seconds:00}";
                var full_time = $"{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}";
                var left_time = $"{tsl.Hours:00}:{tsl.Minutes:00}:{tsl.Seconds:00},{tsl.Milliseconds:000}-";

                var sub_time = $"{tse.Hours:00}:{tse.Minutes:00}:{tse.Seconds:00}";

                this.Text = string.Format("{0}", _videoName)
                    + " : " +
                    elapsed_time
                    + " / " +
                    full_time;
                labelCurrentTime.Text = elapsed_time;
                labelDurationTime.Text = full_time;
                labelCurrentVolume.Text = Convert.ToInt32(_player.settings.volume).ToString();
                labelVideoName.Text = _videoName;
                foreach (var item in _manager.GetSubtiles())
                {
                    showHideSubtiles(item, sub_time);
                }
                /*foreach (var item in _manager.GetSubtiles())
                {
                    if (sub_time == item.Key)
                    {
                        if (item.Value.Text1!="")
                            labelSubtilesLine1.Text = item.Value.Text1;
                        if (item.Value.Text2 != "")
                            labelSubtilesLine2.Text = item.Value.Text2;
                        if (item.Value.Text3 != "")
                            labelSubtilesLine3.Text = item.Value.Text3;
                    }
                    if (sub_time == item.Value.EndTime)
                    {
                        labelSubtilesLine1.Text = "";
                        labelSubtilesLine2.Text = "";
                        labelSubtilesLine3.Text = "";
                    }
                }*/
               
                if (WidgetTime)
                {
                    switch (TimeWidgetValue)
                    {
                        case TimeWidget.None:
                            labelWidgetTime.Visible = false;
                            break;
                        case TimeWidget.Elapsed:
                            labelWidgetTime.Visible = true;
                            labelWidgetTime.Text = elapsed_time;
                            break;
                        case TimeWidget.Left:
                            labelWidgetTime.Visible = true;
                            labelWidgetTime.Text = left_time;
                            break;
                    }
                }
            }
        }
        #endregion

        private void showHideSubtiles()
        {
            labelSubtilesLine1.Text = "";
            labelSubtilesLine2.Text = "";
            labelSubtilesLine3.Text = "";
        }

        private void showHideSubtiles(KeyValuePair<string, Subtile> item, string time= null)
        {

            if (time == item.Key)
            {
                if (item.Value.Text1 != "")
                    labelSubtilesLine1.Text = item.Value.Text1;
                if (item.Value.Text2 != "")
                    labelSubtilesLine2.Text = item.Value.Text2;
                if (item.Value.Text3 != "")
                    labelSubtilesLine3.Text = item.Value.Text3;
            }
            if (time == item.Value.EndTime || time==null)
            {
                labelSubtilesLine1.Text = "";
                labelSubtilesLine2.Text = "";
                labelSubtilesLine3.Text = "";
            }
        }

        private TimeSpan ParseTimeSpan(string time)
        {
            return TimeSpan.Parse(time);
        }

        private TimeSpan GetTimeSpan(double val)
        {
            return TimeSpan.FromSeconds(val);
        }

        #region TrackBar
        private void colorSliderTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (_player != null)
            {
                _player.Ctlcontrols.currentPosition = (double)e.NewValue;
            }
        }
        #endregion

        #region Mouse Event
        private void pbPlay_Click(object sender, EventArgs e)
        {
            if (_player != null && _player.URL!="")
            {
                if (_player.playState == WMPPlayState.wmppsPlaying)
                {
                    _player.Ctlcontrols.pause();
                    _timer.Enabled = false;
                    pbPlay.Image = Properties.Resources.pause;
                }
                else
                {
                    _player.Ctlcontrols.play();
                    _timer.Enabled = true;
                    pbPlay.Image = Properties.Resources.play;
                }
            }
        }

        private void pbStop_Click(object sender, EventArgs e)
        {
            if (_player != null && _player.URL != "")
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

        private async void pbOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Video files(*.avi;*.mp4;*.mkv;*.wmv;*.mpg;*.mpeg;*.mp3)|*.avi;*.mp4;*.mkv;*.wmv;*.mpg;*.mpeg;*.mp3|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var video_file = ofd.FileName;
                var dir = new FileInfo(video_file).Directory.FullName;
                var ext = new FileInfo(video_file).Extension;
                _videoName = video_file.Replace(dir + "\\", String.Empty);
                _videoName = video_file.Replace(ext, String.Empty);
                try
                {
                    Clear();
                    _player.URL = ofd.FileName;
                    _player.PlayStateChange += Player_PlayStateChange;
                    _timer.Enabled = true;
                    _maxTime = _player.currentMedia.duration;
                    _player.EndOfStream += _player_EndOfStream;
                    
                    if (File.Exists(_videoName + ".srt"))
                    {
                        _subtilesFile = _videoName + ".srt";
                        //var manager = new SubtileManager();
                        var sub = new SubtileManager(_subtilesFile);
                        //MessageBox.Show(sub.Count.ToString());
                        //sub.ReadFromFile(_subtilesFile);
                        _manager = sub;
                    }
                    await ShowEventLabel("Open file");
                    //Logger.Net48.Logger.Write(this, new Log() { LogType = LogType.Info, Message = $"Opening video file: {video_file}", SenderType = Logger.Net48.Logger.GetMethodName() });
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[{ex.HResult}]: {ex.Message}");
                }
            }
        }

        private void pbFullscreen_Click(object sender, EventArgs e)
        {
            if (_player != null)
            {
                FullScreen();
            }
        }

        private void pbSettings_Click(object sender, EventArgs e)
        {
            Forms.FormSettings form = new Forms.FormSettings();
            form.ShowDialog();
            //Forms.FormSubtiles subtiles = new FormSubtiles();
            //subtiles.Show();
        }
        #endregion

        #region Dispose at end of stream
        private void _player_EndOfStream(object sender, _WMPOCXEvents_EndOfStreamEvent e)
        {
            Clear();
            _player.Dispose();
            colorSliderTrackBar.Minimum = 0;
            colorSliderTrackBar.Maximum = (int)_player.currentMedia.duration;
        }
        #endregion

        #region Player state
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
        #endregion

        #region Clear video
        private void Clear()
        {
            if (_player != null)
            {
                _player.URL = null;
                _timer.Enabled = false;
            }
        }
        #endregion

        #region Mouse moving and waiting for move
        /// <summary>
        /// When mouse not moving x seconds, event will start
        /// </summary>
        private void _mouseMoveFilter_OnMouseNotMove(object sender, EventArgs e)
        {
            panelControl.Hide();
            Cursor.Hide();
            if (_player != null && _fullscreen)
                Cursor.Hide();
            Invalidate();
        }

        /// <summary>
        /// If move move
        /// </summary>
        private void _mouseMoveFilter_OnMouseMove(object sender, MouseEventArgs e)
        {
            panelControl.Show();
            Cursor.Show();
            if (_player != null && _fullscreen)
                Cursor.Show();
            Invalidate();
        }

        /// <summary>
        /// WND Proc for mouse message
        /// </summary>
        /// <param name="m">ref message</param>
        protected override void WndProc(ref Message m)
        {
            // Listen for operating system messages
            switch (m.Msg)
            {
                case WM_MOUSEMOVE:
                    this.MouseMove += VideoControlBar_MouseMove;
                    break;
                case WM_KEYDOWN:
                    this.KeyDown += VideoControlBar_KeyDown;
                    break;
            }
            base.WndProc(ref m);
        }

        private void VideoControlBar_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void VideoControlBar_KeyDown(object sender, KeyEventArgs e)
        {

        }
        #endregion

        private void labelSubtilesLine1_TextChanged(object sender, EventArgs e)
        {
            labelSubtilesLine1.Location = new Point((Width / 2) - (labelSubtilesLine1.Width), Height - ((4 * labelSubtilesLine1.Height) + labelSubtilesLine1.Height));
        }

        private void labelSubtilesLine2_TextChanged(object sender, EventArgs e)
        {
            labelSubtilesLine2.Location = new Point((Width / 2) - (labelSubtilesLine2.Width), Height - ((2 * labelSubtilesLine1.Height) + labelSubtilesLine1.Height));
        }
        private void labelSubtilesLine3_TextChanged(object sender, EventArgs e)
        {
            labelSubtilesLine3.Location = new Point((Width / 2) - (labelSubtilesLine3.Width), Height - ((0 * labelSubtilesLine3.Height) + labelSubtilesLine3.Height));
        }

        private void pbSubtilesOnOff_Click(object sender, EventArgs e)
        {
            if (!ShowSubtiles)
            {
                
                labelSubtilesLine1.Visible = true;
                labelSubtilesLine2.Visible = true;
                labelSubtilesLine3.Visible = true;
                labelOnOff.Text = "On";
                labelOnOff.ForeColor = Color.FromArgb(0, 255, 0);
                ShowSubtiles = true;
                
                translate();
                
                Refresh();
            }
            else
            {
                
                labelSubtilesLine1.Visible = false;
                labelSubtilesLine2.Visible = false;
                labelSubtilesLine3.Visible = false;
                labelOnOff.Text = "Off";
                labelOnOff.ForeColor = Color.FromArgb(255, 0, 0);
                ShowSubtiles = false;
                
                translate();

                Refresh();
            }
            
        }
    }

    public class TextLocationEventArgs : EventArgs
    {
        public Point Point { get; set; }
        public TextLocationType Position { get; set; }
    }

    [Flags]
    public enum TimeWidget
    {
        None = 0,
        Elapsed,
        Left
    }

    
}
