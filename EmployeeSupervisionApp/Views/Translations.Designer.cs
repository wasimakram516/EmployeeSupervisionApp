namespace EmployeeSupervisionApp.Views
{
    partial class Translations
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
            txtTranslationText = new TextBox();
            label2 = new Label();
            ddLanguage = new ComboBox();
            errLanguage = new Label();
            errElementKey = new Label();
            ddElementKey = new ComboBox();
            label5 = new Label();
            errTranslationText = new Label();
            label7 = new Label();
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
            pnlForm.Controls.Add(errTranslationText);
            pnlForm.Controls.Add(label7);
            pnlForm.Controls.Add(errElementKey);
            pnlForm.Controls.Add(ddElementKey);
            pnlForm.Controls.Add(label5);
            pnlForm.Controls.Add(errLanguage);
            pnlForm.Controls.Add(ddLanguage);
            pnlForm.Controls.Add(label2);
            pnlForm.Controls.Add(txtTranslationText);
            pnlForm.Size = new Size(300, 390);
            // 
            // pnlDetails
            // 
            pnlDetails.Size = new Size(500, 390);
            // 
            // txtTranslationText
            // 
            txtTranslationText.Location = new Point(12, 203);
            txtTranslationText.Name = "txtTranslationText";
            txtTranslationText.Size = new Size(280, 29);
            txtTranslationText.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 1;
            label2.Text = "Language";
            // 
            // ddLanguage
            // 
            ddLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            ddLanguage.FormattingEnabled = true;
            ddLanguage.Location = new Point(12, 90);
            ddLanguage.Name = "ddLanguage";
            ddLanguage.Size = new Size(280, 29);
            ddLanguage.TabIndex = 2;
            // 
            // errLanguage
            // 
            errLanguage.AutoSize = true;
            errLanguage.Location = new Point(275, 66);
            errLanguage.Name = "errLanguage";
            errLanguage.Size = new Size(17, 21);
            errLanguage.TabIndex = 3;
            errLanguage.Text = "*";
            // 
            // errElementKey
            // 
            errElementKey.AutoSize = true;
            errElementKey.Location = new Point(275, 123);
            errElementKey.Name = "errElementKey";
            errElementKey.Size = new Size(17, 21);
            errElementKey.TabIndex = 6;
            errElementKey.Text = "*";
            // 
            // ddElementKey
            // 
            ddElementKey.DropDownStyle = ComboBoxStyle.DropDownList;
            ddElementKey.FormattingEnabled = true;
            ddElementKey.Location = new Point(12, 147);
            ddElementKey.Name = "ddElementKey";
            ddElementKey.Size = new Size(280, 29);
            ddElementKey.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 122);
            label5.Name = "label5";
            label5.Size = new Size(66, 21);
            label5.TabIndex = 4;
            label5.Text = "Element";
            // 
            // errTranslationText
            // 
            errTranslationText.AutoSize = true;
            errTranslationText.Location = new Point(275, 180);
            errTranslationText.Name = "errTranslationText";
            errTranslationText.Size = new Size(17, 21);
            errTranslationText.TabIndex = 8;
            errTranslationText.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 179);
            label7.Name = "label7";
            label7.Size = new Size(116, 21);
            label7.TabIndex = 7;
            label7.Text = "Translation Text";
            // 
            // Translations
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Translations";
            Text = "Translations";
            pnlLeft.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            pnlTopLeft.ResumeLayout(false);
            pnlTopRight.ResumeLayout(false);
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label errTranslationText;
        private Label label7;
        private Label errElementKey;
        private ComboBox ddElementKey;
        private Label label5;
        private Label errLanguage;
        private ComboBox ddLanguage;
        private Label label2;
        private TextBox txtTranslationText;
    }
}