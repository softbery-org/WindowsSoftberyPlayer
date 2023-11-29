// Version: 1.0.0.121
namespace WindowsSoftberyPlayer.Panels
{
    partial class SettingsSubtile
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
            this.labelFont = new System.Windows.Forms.Label();
            this.textBoxFont = new System.Windows.Forms.TextBox();
            this.btnGetFont = new System.Windows.Forms.Button();
            this.checkBoxSubtileColor = new System.Windows.Forms.CheckBox();
            this.checkBoxSubtileStartOnVideoPlay = new System.Windows.Forms.CheckBox();
            this.checkBoxShowSubtilesOnVideoStart = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelFont
            // 
            this.labelFont.AutoSize = true;
            this.labelFont.Location = new System.Drawing.Point(3, 69);
            this.labelFont.Name = "labelFont";
            this.labelFont.Size = new System.Drawing.Size(31, 13);
            this.labelFont.TabIndex = 11;
            this.labelFont.Text = "Font:";
            // 
            // textBoxFont
            // 
            this.textBoxFont.Location = new System.Drawing.Point(3, 85);
            this.textBoxFont.Name = "textBoxFont";
            this.textBoxFont.Size = new System.Drawing.Size(226, 20);
            this.textBoxFont.TabIndex = 10;
            this.textBoxFont.Text = "Calibri; 14pt; Bold";
            // 
            // btnGetFont
            // 
            this.btnGetFont.Location = new System.Drawing.Point(235, 85);
            this.btnGetFont.Name = "btnGetFont";
            this.btnGetFont.Size = new System.Drawing.Size(27, 23);
            this.btnGetFont.TabIndex = 9;
            this.btnGetFont.Text = "...";
            this.btnGetFont.UseVisualStyleBackColor = true;
            // 
            // checkBoxSubtileColor
            // 
            this.checkBoxSubtileColor.AutoSize = true;
            this.checkBoxSubtileColor.Location = new System.Drawing.Point(3, 49);
            this.checkBoxSubtileColor.Name = "checkBoxSubtileColor";
            this.checkBoxSubtileColor.Size = new System.Drawing.Size(89, 17);
            this.checkBoxSubtileColor.TabIndex = 8;
            this.checkBoxSubtileColor.Text = "Subtiles color";
            this.checkBoxSubtileColor.UseVisualStyleBackColor = true;
            // 
            // checkBoxSubtileStartOnVideoPlay
            // 
            this.checkBoxSubtileStartOnVideoPlay.AutoSize = true;
            this.checkBoxSubtileStartOnVideoPlay.Location = new System.Drawing.Point(3, 26);
            this.checkBoxSubtileStartOnVideoPlay.Name = "checkBoxSubtileStartOnVideoPlay";
            this.checkBoxSubtileStartOnVideoPlay.Size = new System.Drawing.Size(158, 17);
            this.checkBoxSubtileStartOnVideoPlay.TabIndex = 7;
            this.checkBoxSubtileStartOnVideoPlay.Text = "Get subtiles like video name";
            this.checkBoxSubtileStartOnVideoPlay.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowSubtilesOnVideoStart
            // 
            this.checkBoxShowSubtilesOnVideoStart.AutoSize = true;
            this.checkBoxShowSubtilesOnVideoStart.Location = new System.Drawing.Point(3, 3);
            this.checkBoxShowSubtilesOnVideoStart.Name = "checkBoxShowSubtilesOnVideoStart";
            this.checkBoxShowSubtilesOnVideoStart.Size = new System.Drawing.Size(158, 17);
            this.checkBoxShowSubtilesOnVideoStart.TabIndex = 6;
            this.checkBoxShowSubtilesOnVideoStart.Text = "Show subtiles on video start";
            this.checkBoxShowSubtilesOnVideoStart.UseVisualStyleBackColor = true;
            // 
            // SettingsSubtile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelFont);
            this.Controls.Add(this.textBoxFont);
            this.Controls.Add(this.btnGetFont);
            this.Controls.Add(this.checkBoxSubtileColor);
            this.Controls.Add(this.checkBoxSubtileStartOnVideoPlay);
            this.Controls.Add(this.checkBoxShowSubtilesOnVideoStart);
            this.Name = "SettingsSubtile";
            this.Size = new System.Drawing.Size(492, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFont;
        private System.Windows.Forms.TextBox textBoxFont;
        private System.Windows.Forms.Button btnGetFont;
        private System.Windows.Forms.CheckBox checkBoxSubtileColor;
        private System.Windows.Forms.CheckBox checkBoxSubtileStartOnVideoPlay;
        private System.Windows.Forms.CheckBox checkBoxShowSubtilesOnVideoStart;
    }
}
