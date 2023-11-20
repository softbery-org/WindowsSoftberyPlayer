﻿namespace WindowsSoftberyPlayer.ControlBar
{
    partial class WMPControlsBar
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WMPControlsBar));
            this.panelControl = new System.Windows.Forms.Panel();
            this.colorSliderTrackBar = new MB.Controls.ColorSliderV2();
            this.pbSettings = new System.Windows.Forms.PictureBox();
            this.pbVolumeDown = new System.Windows.Forms.PictureBox();
            this.labelCurrentVolume = new System.Windows.Forms.Label();
            this.pbVolumeUp = new System.Windows.Forms.PictureBox();
            this.pbMute = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbOpen = new System.Windows.Forms.PictureBox();
            this.pbForward = new System.Windows.Forms.PictureBox();
            this.pbFullscreen = new System.Windows.Forms.PictureBox();
            this.pbStop = new System.Windows.Forms.PictureBox();
            this.pbPlay = new System.Windows.Forms.PictureBox();
            this.pbRewind = new System.Windows.Forms.PictureBox();
            this.labelVideoName = new System.Windows.Forms.Label();
            this.labelDurationTime = new System.Windows.Forms.Label();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.axWMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolumeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolumeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFullscreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRewind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl.Controls.Add(this.colorSliderTrackBar);
            this.panelControl.Controls.Add(this.pbSettings);
            this.panelControl.Controls.Add(this.pbVolumeDown);
            this.panelControl.Controls.Add(this.labelCurrentVolume);
            this.panelControl.Controls.Add(this.pbVolumeUp);
            this.panelControl.Controls.Add(this.pbMute);
            this.panelControl.Controls.Add(this.label1);
            this.panelControl.Controls.Add(this.pbOpen);
            this.panelControl.Controls.Add(this.pbForward);
            this.panelControl.Controls.Add(this.pbFullscreen);
            this.panelControl.Controls.Add(this.pbStop);
            this.panelControl.Controls.Add(this.pbPlay);
            this.panelControl.Controls.Add(this.pbRewind);
            this.panelControl.Controls.Add(this.labelVideoName);
            this.panelControl.Controls.Add(this.labelDurationTime);
            this.panelControl.Controls.Add(this.labelCurrentTime);
            this.panelControl.Location = new System.Drawing.Point(0, 417);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(813, 77);
            this.panelControl.TabIndex = 35;
            // 
            // colorSliderTrackBar
            // 
            this.colorSliderTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorSliderTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(95)))));
            this.colorSliderTrackBar.BarPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.colorSliderTrackBar.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(74)))));
            this.colorSliderTrackBar.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSliderTrackBar.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.colorSliderTrackBar.ElapsedPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(130)))), ((int)(((byte)(208)))));
            this.colorSliderTrackBar.ElapsedPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            this.colorSliderTrackBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.colorSliderTrackBar.ForeColor = System.Drawing.Color.White;
            this.colorSliderTrackBar.LargeChange = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.colorSliderTrackBar.Location = new System.Drawing.Point(142, 38);
            this.colorSliderTrackBar.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.colorSliderTrackBar.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.colorSliderTrackBar.MouseWheelBarPartitions = 5;
            this.colorSliderTrackBar.Name = "colorSliderTrackBar";
            this.colorSliderTrackBar.ScaleDivisions = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.colorSliderTrackBar.ScaleSubDivisions = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.colorSliderTrackBar.ShowDivisionsText = true;
            this.colorSliderTrackBar.ShowSmallScale = true;
            this.colorSliderTrackBar.Size = new System.Drawing.Size(483, 23);
            this.colorSliderTrackBar.SmallChange = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.colorSliderTrackBar.TabIndex = 49;
            this.colorSliderTrackBar.Text = "colorSlider1";
            this.colorSliderTrackBar.ThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.colorSliderTrackBar.ThumbPenColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.colorSliderTrackBar.ThumbRoundRectSize = new System.Drawing.Size(16, 16);
            this.colorSliderTrackBar.ThumbSize = new System.Drawing.Size(16, 16);
            this.colorSliderTrackBar.TickAdd = 10F;
            this.colorSliderTrackBar.TickColor = System.Drawing.Color.DarkOrange;
            this.colorSliderTrackBar.TickDivide = 5F;
            this.colorSliderTrackBar.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.colorSliderTrackBar.ValueChanged += new System.EventHandler(this.colorSliderTrackBar_ValueChanged);
            this.colorSliderTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.colorSliderTrackBar_Scroll);
            this.colorSliderTrackBar.Click += new System.EventHandler(this.colorSliderTrackBar_Click);
            // 
            // pbSettings
            // 
            this.pbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSettings.BackColor = System.Drawing.Color.Transparent;
            this.pbSettings.Image = global::Properties.Resources.settings;
            this.pbSettings.Location = new System.Drawing.Point(631, 32);
            this.pbSettings.Name = "pbSettings";
            this.pbSettings.Size = new System.Drawing.Size(40, 40);
            this.pbSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSettings.TabIndex = 48;
            this.pbSettings.TabStop = false;
            // 
            // pbVolumeDown
            // 
            this.pbVolumeDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbVolumeDown.BackColor = System.Drawing.Color.Transparent;
            this.pbVolumeDown.Image = global::Properties.Resources.low_volume;
            this.pbVolumeDown.Location = new System.Drawing.Point(579, 12);
            this.pbVolumeDown.Name = "pbVolumeDown";
            this.pbVolumeDown.Size = new System.Drawing.Size(20, 20);
            this.pbVolumeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVolumeDown.TabIndex = 47;
            this.pbVolumeDown.TabStop = false;
            this.pbVolumeDown.Click += new System.EventHandler(this.pbVolumeDown_Click);
            // 
            // labelCurrentVolume
            // 
            this.labelCurrentVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurrentVolume.AutoSize = true;
            this.labelCurrentVolume.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentVolume.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCurrentVolume.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCurrentVolume.Location = new System.Drawing.Point(603, 14);
            this.labelCurrentVolume.Name = "labelCurrentVolume";
            this.labelCurrentVolume.Size = new System.Drawing.Size(46, 15);
            this.labelCurrentVolume.TabIndex = 46;
            this.labelCurrentVolume.Text = "-10000";
            // 
            // pbVolumeUp
            // 
            this.pbVolumeUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbVolumeUp.BackColor = System.Drawing.Color.Transparent;
            this.pbVolumeUp.Image = global::Properties.Resources.audio;
            this.pbVolumeUp.Location = new System.Drawing.Point(651, 12);
            this.pbVolumeUp.Name = "pbVolumeUp";
            this.pbVolumeUp.Size = new System.Drawing.Size(20, 20);
            this.pbVolumeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVolumeUp.TabIndex = 45;
            this.pbVolumeUp.TabStop = false;
            this.pbVolumeUp.Click += new System.EventHandler(this.pbVolumeUp_Click);
            // 
            // pbMute
            // 
            this.pbMute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMute.BackColor = System.Drawing.Color.Transparent;
            this.pbMute.Image = global::Properties.Resources.mute;
            this.pbMute.Location = new System.Drawing.Point(553, 12);
            this.pbMute.Name = "pbMute";
            this.pbMute.Size = new System.Drawing.Size(20, 20);
            this.pbMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMute.TabIndex = 44;
            this.pbMute.TabStop = false;
            this.pbMute.Click += new System.EventHandler(this.pbMute_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(738, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "/";
            // 
            // pbOpen
            // 
            this.pbOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbOpen.BackColor = System.Drawing.Color.Transparent;
            this.pbOpen.Image = global::Properties.Resources.open;
            this.pbOpen.Location = new System.Drawing.Point(677, 32);
            this.pbOpen.Name = "pbOpen";
            this.pbOpen.Size = new System.Drawing.Size(40, 40);
            this.pbOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOpen.TabIndex = 42;
            this.pbOpen.TabStop = false;
            this.pbOpen.Click += new System.EventHandler(this.pbOpen_Click);
            // 
            // pbForward
            // 
            this.pbForward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbForward.BackColor = System.Drawing.Color.Transparent;
            this.pbForward.Image = global::Properties.Resources.forward;
            this.pbForward.Location = new System.Drawing.Point(723, 32);
            this.pbForward.Name = "pbForward";
            this.pbForward.Size = new System.Drawing.Size(40, 40);
            this.pbForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbForward.TabIndex = 41;
            this.pbForward.TabStop = false;
            // 
            // pbFullscreen
            // 
            this.pbFullscreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFullscreen.BackColor = System.Drawing.Color.Transparent;
            this.pbFullscreen.Image = global::Properties.Resources.fullscreen;
            this.pbFullscreen.Location = new System.Drawing.Point(769, 32);
            this.pbFullscreen.Name = "pbFullscreen";
            this.pbFullscreen.Size = new System.Drawing.Size(40, 40);
            this.pbFullscreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFullscreen.TabIndex = 40;
            this.pbFullscreen.TabStop = false;
            this.pbFullscreen.Click += new System.EventHandler(this.pbFullscreen_Click);
            // 
            // pbStop
            // 
            this.pbStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbStop.BackColor = System.Drawing.Color.Transparent;
            this.pbStop.Image = global::Properties.Resources.stop;
            this.pbStop.Location = new System.Drawing.Point(96, 32);
            this.pbStop.Name = "pbStop";
            this.pbStop.Size = new System.Drawing.Size(40, 40);
            this.pbStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStop.TabIndex = 39;
            this.pbStop.TabStop = false;
            this.pbStop.Click += new System.EventHandler(this.pbStop_Click);
            // 
            // pbPlay
            // 
            this.pbPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbPlay.BackColor = System.Drawing.Color.Transparent;
            this.pbPlay.Image = global::Properties.Resources.play;
            this.pbPlay.Location = new System.Drawing.Point(50, 32);
            this.pbPlay.Name = "pbPlay";
            this.pbPlay.Size = new System.Drawing.Size(40, 40);
            this.pbPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlay.TabIndex = 38;
            this.pbPlay.TabStop = false;
            this.pbPlay.Click += new System.EventHandler(this.pbPlay_Click);
            // 
            // pbRewind
            // 
            this.pbRewind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbRewind.BackColor = System.Drawing.Color.Transparent;
            this.pbRewind.Image = global::Properties.Resources.rewind;
            this.pbRewind.Location = new System.Drawing.Point(4, 32);
            this.pbRewind.Name = "pbRewind";
            this.pbRewind.Size = new System.Drawing.Size(40, 40);
            this.pbRewind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRewind.TabIndex = 37;
            this.pbRewind.TabStop = false;
            // 
            // labelVideoName
            // 
            this.labelVideoName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelVideoName.AutoSize = true;
            this.labelVideoName.BackColor = System.Drawing.Color.Transparent;
            this.labelVideoName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVideoName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelVideoName.Location = new System.Drawing.Point(4, 14);
            this.labelVideoName.Name = "labelVideoName";
            this.labelVideoName.Size = new System.Drawing.Size(139, 15);
            this.labelVideoName.TabIndex = 36;
            this.labelVideoName.Text = "current_video_name.avi";
            // 
            // labelDurationTime
            // 
            this.labelDurationTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDurationTime.AutoSize = true;
            this.labelDurationTime.BackColor = System.Drawing.Color.Transparent;
            this.labelDurationTime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDurationTime.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDurationTime.Location = new System.Drawing.Point(752, 14);
            this.labelDurationTime.Name = "labelDurationTime";
            this.labelDurationTime.Size = new System.Drawing.Size(57, 15);
            this.labelDurationTime.TabIndex = 35;
            this.labelDurationTime.Text = "00:00:00";
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurrentTime.AutoSize = true;
            this.labelCurrentTime.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentTime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCurrentTime.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCurrentTime.Location = new System.Drawing.Point(677, 14);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(57, 15);
            this.labelCurrentTime.TabIndex = 34;
            this.labelCurrentTime.Text = "00:00:00";
            // 
            // axWMP
            // 
            this.axWMP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWMP.Enabled = true;
            this.axWMP.Location = new System.Drawing.Point(0, 0);
            this.axWMP.Name = "axWMP";
            this.axWMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP.OcxState")));
            this.axWMP.Size = new System.Drawing.Size(813, 494);
            this.axWMP.TabIndex = 34;
            // 
            // WMPControlsBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(95)))));
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.axWMP);
            this.Name = "WMPControlsBar";
            this.Size = new System.Drawing.Size(813, 494);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolumeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolumeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFullscreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRewind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer axWMP;
        private System.Windows.Forms.Panel panelControl;
        private MB.Controls.ColorSliderV2 colorSliderTrackBar;
        private System.Windows.Forms.PictureBox pbSettings;
        private System.Windows.Forms.PictureBox pbVolumeDown;
        private System.Windows.Forms.Label labelCurrentVolume;
        private System.Windows.Forms.PictureBox pbVolumeUp;
        private System.Windows.Forms.PictureBox pbMute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbOpen;
        private System.Windows.Forms.PictureBox pbForward;
        private System.Windows.Forms.PictureBox pbFullscreen;
        private System.Windows.Forms.PictureBox pbStop;
        private System.Windows.Forms.PictureBox pbPlay;
        private System.Windows.Forms.PictureBox pbRewind;
        private System.Windows.Forms.Label labelVideoName;
        private System.Windows.Forms.Label labelDurationTime;
        private System.Windows.Forms.Label labelCurrentTime;
    }
}
