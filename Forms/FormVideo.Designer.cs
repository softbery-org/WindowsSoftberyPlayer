// Version: 1.0.0.143
namespace WindowsSoftberyPlayer.Forms
{
    partial class FormVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVideo));
            this.axWMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.subtiles1 = new WindowsSoftberyPlayer.ControlBar.Subtiles();
            this.controlBar1 = new WindowsSoftberyPlayer.ControlBar.ControlBar();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).BeginInit();
            this.SuspendLayout();
            // 
            // axWMP
            // 
            this.axWMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWMP.Enabled = true;
            this.axWMP.Location = new System.Drawing.Point(0, 0);
            this.axWMP.Name = "axWMP";
            this.axWMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP.OcxState")));
            this.axWMP.Size = new System.Drawing.Size(1127, 545);
            this.axWMP.TabIndex = 0;
            // 
            // subtiles1
            // 
            this.subtiles1.AutoSize = true;
            this.subtiles1.BackColor = System.Drawing.Color.Silver;
            this.subtiles1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.subtiles1.Location = new System.Drawing.Point(0, 435);
            this.subtiles1.Name = "subtiles1";
            this.subtiles1.Size = new System.Drawing.Size(1127, 110);
            this.subtiles1.TabIndex = 1;
            // 
            // controlBar1
            // 
            this.controlBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlBar1.Location = new System.Drawing.Point(0, 469);
            this.controlBar1.Name = "controlBar1";
            this.controlBar1.Size = new System.Drawing.Size(1127, 76);
            this.controlBar1.TabIndex = 2;
            // 
            // FormVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 545);
            this.Controls.Add(this.controlBar1);
            this.Controls.Add(this.subtiles1);
            this.Controls.Add(this.axWMP);
            this.Name = "FormVideo";
            this.Text = "FormVideo";
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWMP;
        private ControlBar.Subtiles subtiles1;
        private ControlBar.ControlBar controlBar1;
    }
}
