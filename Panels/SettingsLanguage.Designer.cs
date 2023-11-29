// Version: 1.0.0.146
namespace WindowsSoftberyPlayer.Panels
{
    partial class SettingsLanguage
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
            this.comboBoxLangList = new System.Windows.Forms.ComboBox();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxLangList
            // 
            this.comboBoxLangList.FormattingEnabled = true;
            this.comboBoxLangList.Location = new System.Drawing.Point(76, 10);
            this.comboBoxLangList.Name = "comboBoxLangList";
            this.comboBoxLangList.Size = new System.Drawing.Size(152, 21);
            this.comboBoxLangList.TabIndex = 0;
            this.comboBoxLangList.SelectedIndexChanged += new System.EventHandler(this.comboBoxLangList_SelectedIndexChanged);
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Location = new System.Drawing.Point(12, 13);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(58, 13);
            this.labelLanguage.TabIndex = 1;
            this.labelLanguage.Text = "Language:";
            // 
            // SettingsLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.comboBoxLangList);
            this.Name = "SettingsLanguage";
            this.Size = new System.Drawing.Size(250, 41);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLangList;
        private System.Windows.Forms.Label labelLanguage;
    }
}
