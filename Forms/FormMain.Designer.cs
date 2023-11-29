// Version: 1.0.0.502
namespace WindowsSoftberyPlayer.Forms
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.videoControlBar1 = new WindowsSoftberyPlayer.ControlBar.VideoControlBar();
            this.SuspendLayout();
            // 
            // videoControlBar1
            // 
            this.videoControlBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoControlBar1.Location = new System.Drawing.Point(0, 0);
            this.videoControlBar1.Name = "videoControlBar1";
            this.videoControlBar1.Opacity = 50;
            this.videoControlBar1.OpacityColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.videoControlBar1.Owner = null;
            this.videoControlBar1.SeekTime = 10;
            this.videoControlBar1.ShowSubtiles = false;
            this.videoControlBar1.Size = new System.Drawing.Size(1043, 497);
            this.videoControlBar1.TabIndex = 0;
            this.videoControlBar1.TimeWidgetValue = WindowsSoftberyPlayer.ControlBar.TimeWidget.Left;
            this.videoControlBar1.WidgetTime = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 497);
            this.Controls.Add(this.videoControlBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlBar.VideoControlBar videoControlBar1;
    }
}
