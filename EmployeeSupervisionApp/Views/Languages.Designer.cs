namespace EmployeeSupervisionApp.Views
{
    partial class Languages
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
            label2 = new Label();
            txtLanguageCode = new TextBox();
            errLanguageCode = new Label();
            errLanguageName = new Label();
            txtLanguageName = new TextBox();
            label5 = new Label();
            pnlLeft.SuspendLayout();
            pnlRight.SuspendLayout();
            pnlTopLeft.SuspendLayout();
            pnlTopRight.SuspendLayout();
            pnlForm.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Size = new Size(73, 29);
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderSize = 0;
            // 
            // pnlLeft
            // 
            pnlLeft.Size = new Size(300, 450);
            // 
            // pnlRight
            // 
            pnlRight.Size = new Size(500, 450);
            // 
            // pnlTopRight
            // 
            pnlTopRight.Size = new Size(500, 60);
            // 
            // pnlForm
            // 
            pnlForm.Controls.Add(errLanguageName);
            pnlForm.Controls.Add(txtLanguageName);
            pnlForm.Controls.Add(label5);
            pnlForm.Controls.Add(errLanguageCode);
            pnlForm.Controls.Add(txtLanguageCode);
            pnlForm.Controls.Add(label2);
            pnlForm.Size = new Size(300, 390);
            // 
            // pnlDetails
            // 
            pnlDetails.Size = new Size(500, 390);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(118, 21);
            label2.TabIndex = 0;
            label2.Text = "Language Code";
            // 
            // txtLanguageCode
            // 
            txtLanguageCode.Location = new Point(12, 90);
            txtLanguageCode.Name = "txtLanguageCode";
            txtLanguageCode.Size = new Size(280, 29);
            txtLanguageCode.TabIndex = 1;
            // 
            // errLanguageCode
            // 
            errLanguageCode.AutoSize = true;
            errLanguageCode.Location = new Point(275, 66);
            errLanguageCode.Name = "errLanguageCode";
            errLanguageCode.Size = new Size(17, 21);
            errLanguageCode.TabIndex = 2;
            errLanguageCode.Text = "*";
            // 
            // errLanguageName
            // 
            errLanguageName.AutoSize = true;
            errLanguageName.Location = new Point(275, 122);
            errLanguageName.Name = "errLanguageName";
            errLanguageName.Size = new Size(17, 21);
            errLanguageName.TabIndex = 5;
            errLanguageName.Text = "*";
            // 
            // txtLanguageName
            // 
            txtLanguageName.Location = new Point(12, 146);
            txtLanguageName.Name = "txtLanguageName";
            txtLanguageName.Size = new Size(280, 29);
            txtLanguageName.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 121);
            label5.Name = "label5";
            label5.Size = new Size(124, 21);
            label5.TabIndex = 3;
            label5.Text = "Language Name";
            // 
            // Languages
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Languages";
            Text = "Languages";
            pnlLeft.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            pnlTopLeft.ResumeLayout(false);
            pnlTopRight.ResumeLayout(false);
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label errLanguageName;
        private TextBox txtLanguageName;
        private Label label5;
        private Label errLanguageCode;
        private TextBox txtLanguageCode;
        private Label label2;
    }
}