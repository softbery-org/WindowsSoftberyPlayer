// Version: 1.0.0.143
namespace WindowsSoftberyPlayer.ControlBar
{
    partial class VideoPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoPanel));
            this.axVideo = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // axVideo
            // 
            this.axVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axVideo.Enabled = true;
            this.axVideo.Location = new System.Drawing.Point(0, 0);
            this.axVideo.Name = "axVideo";
            this.axVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideo.OcxState")));
            this.axVideo.Size = new System.Drawing.Size(984, 479);
            this.axVideo.TabIndex = 0;
            // 
            // VideoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.axVideo);
            this.Name = "VideoPanel";
            this.Size = new System.Drawing.Size(984, 479);
            ((System.ComponentModel.ISupportInitialize)(this.axVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axVideo;
    }
}
