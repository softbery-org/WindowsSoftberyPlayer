// Version: 1.0.0.167
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
            this.videoControlBar1.Owner = this;
            this.videoControlBar1.Size = new System.Drawing.Size(787, 554);
            this.videoControlBar1.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 554);
            this.Controls.Add(this.videoControlBar1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlBar.VideoControlBar videoControlBar1;
    }
}
