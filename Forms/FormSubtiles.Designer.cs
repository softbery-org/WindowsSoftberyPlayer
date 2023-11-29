// Version: 1.0.0.281
namespace WindowsSoftberyPlayer.Forms
{
    partial class FormSubtiles
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
            this.listBoxStartTime = new System.Windows.Forms.ListBox();
            this.listBoxEndTime = new System.Windows.Forms.ListBox();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.labelEndTime = new System.Windows.Forms.Label();
            this.richTextBoxLineI = new System.Windows.Forms.RichTextBox();
            this.richTextBoxLineII = new System.Windows.Forms.RichTextBox();
            this.richTextBoxLineIII = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxStartTime
            // 
            this.listBoxStartTime.FormattingEnabled = true;
            this.listBoxStartTime.Location = new System.Drawing.Point(12, 38);
            this.listBoxStartTime.Name = "listBoxStartTime";
            this.listBoxStartTime.Size = new System.Drawing.Size(107, 342);
            this.listBoxStartTime.TabIndex = 0;
            this.listBoxStartTime.SelectedIndexChanged += new System.EventHandler(this.listBoxStartTime_SelectedIndexChanged);
            // 
            // listBoxEndTime
            // 
            this.listBoxEndTime.FormattingEnabled = true;
            this.listBoxEndTime.Location = new System.Drawing.Point(125, 38);
            this.listBoxEndTime.Name = "listBoxEndTime";
            this.listBoxEndTime.Size = new System.Drawing.Size(107, 342);
            this.listBoxEndTime.TabIndex = 1;
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Location = new System.Drawing.Point(12, 22);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(29, 13);
            this.labelStartTime.TabIndex = 2;
            this.labelStartTime.Text = "Start";
            // 
            // labelEndTime
            // 
            this.labelEndTime.AutoSize = true;
            this.labelEndTime.Location = new System.Drawing.Point(122, 22);
            this.labelEndTime.Name = "labelEndTime";
            this.labelEndTime.Size = new System.Drawing.Size(29, 13);
            this.labelEndTime.TabIndex = 3;
            this.labelEndTime.Text = "Stop";
            // 
            // richTextBoxLineI
            // 
            this.richTextBoxLineI.Location = new System.Drawing.Point(238, 38);
            this.richTextBoxLineI.Name = "richTextBoxLineI";
            this.richTextBoxLineI.Size = new System.Drawing.Size(321, 56);
            this.richTextBoxLineI.TabIndex = 4;
            this.richTextBoxLineI.Text = "";
            // 
            // richTextBoxLineII
            // 
            this.richTextBoxLineII.Location = new System.Drawing.Point(238, 113);
            this.richTextBoxLineII.Name = "richTextBoxLineII";
            this.richTextBoxLineII.Size = new System.Drawing.Size(321, 56);
            this.richTextBoxLineII.TabIndex = 5;
            this.richTextBoxLineII.Text = "";
            // 
            // richTextBoxLineIII
            // 
            this.richTextBoxLineIII.Location = new System.Drawing.Point(238, 188);
            this.richTextBoxLineIII.Name = "richTextBoxLineIII";
            this.richTextBoxLineIII.Size = new System.Drawing.Size(321, 56);
            this.richTextBoxLineIII.TabIndex = 6;
            this.richTextBoxLineIII.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Linia I";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Linia II";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Linia III";
            // 
            // FormSubtiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxLineIII);
            this.Controls.Add(this.richTextBoxLineII);
            this.Controls.Add(this.richTextBoxLineI);
            this.Controls.Add(this.labelEndTime);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.listBoxEndTime);
            this.Controls.Add(this.listBoxStartTime);
            this.Name = "FormSubtiles";
            this.Text = "FormSubtiles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxStartTime;
        private System.Windows.Forms.ListBox listBoxEndTime;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.Label labelEndTime;
        private System.Windows.Forms.RichTextBox richTextBoxLineI;
        private System.Windows.Forms.RichTextBox richTextBoxLineII;
        private System.Windows.Forms.RichTextBox richTextBoxLineIII;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
