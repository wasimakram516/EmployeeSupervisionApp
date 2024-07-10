namespace EmployeeSupervisionApp.Views.Dashboards
{
    partial class dbAdmin
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnEmployees = new Button();
            btnLanguages = new Button();
            btnTranslations = new Button();
            label2 = new Label();
            grpLanguage = new GroupBox();
            ddLanguage = new ComboBox();
            pnlLeft.SuspendLayout();
            pnlRight.SuspendLayout();
            pnlTopRight.SuspendLayout();
            pnlForm.SuspendLayout();
            pnlDetails.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            grpLanguage.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.Margin = new Padding(5);
            pnlLeft.Size = new Size(297, 556);
            // 
            // pnlRight
            // 
            pnlRight.Location = new Point(297, 0);
            pnlRight.Margin = new Padding(5);
            pnlRight.Size = new Size(732, 556);
            // 
            // pnlTopLeft
            // 
            pnlTopLeft.Margin = new Padding(5);
            pnlTopLeft.Size = new Size(297, 60);
            // 
            // pnlTopRight
            // 
            pnlTopRight.Controls.Add(grpLanguage);
            pnlTopRight.Margin = new Padding(5);
            pnlTopRight.Size = new Size(732, 60);
            pnlTopRight.Controls.SetChildIndex(lblUserDetails, 0);
            pnlTopRight.Controls.SetChildIndex(grpLanguage, 0);
            // 
            // pnlForm
            // 
            pnlForm.Controls.Add(label2);
            pnlForm.Margin = new Padding(5);
            pnlForm.Size = new Size(297, 496);
            // 
            // pnlDetails
            // 
            pnlDetails.Controls.Add(tableLayoutPanel1);
            pnlDetails.Margin = new Padding(5);
            pnlDetails.Size = new Size(732, 496);
            // 
            // lblUserDetails
            // 
            lblUserDetails.Margin = new Padding(5, 0, 5, 0);
            lblUserDetails.Size = new Size(498, 60);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btnEmployees, 2, 0);
            tableLayoutPanel1.Controls.Add(btnLanguages, 0, 0);
            tableLayoutPanel1.Controls.Add(btnTranslations, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(732, 496);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnEmployees
            // 
            btnEmployees.Dock = DockStyle.Fill;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Image = Properties.Resources.icons8_management_96;
            btnEmployees.Location = new Point(369, 3);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(177, 118);
            btnEmployees.TabIndex = 0;
            btnEmployees.Text = "Employees";
            btnEmployees.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEmployees.UseVisualStyleBackColor = true;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnLanguages
            // 
            btnLanguages.Dock = DockStyle.Fill;
            btnLanguages.FlatStyle = FlatStyle.Flat;
            btnLanguages.Image = Properties.Resources.icons8_language_skill_96;
            btnLanguages.Location = new Point(3, 3);
            btnLanguages.Name = "btnLanguages";
            btnLanguages.Size = new Size(177, 118);
            btnLanguages.TabIndex = 2;
            btnLanguages.Text = "Languages";
            btnLanguages.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLanguages.UseVisualStyleBackColor = true;
            btnLanguages.Click += btnLanguages_Click;
            // 
            // btnTranslations
            // 
            btnTranslations.Dock = DockStyle.Fill;
            btnTranslations.FlatStyle = FlatStyle.Flat;
            btnTranslations.Image = Properties.Resources.icons8_languages_96;
            btnTranslations.Location = new Point(186, 3);
            btnTranslations.Name = "btnTranslations";
            btnTranslations.Size = new Size(177, 118);
            btnTranslations.TabIndex = 1;
            btnTranslations.Text = "Translations";
            btnTranslations.TextImageRelation = TextImageRelation.ImageAboveText;
            btnTranslations.UseVisualStyleBackColor = true;
            btnTranslations.Click += btnTranslations_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 244);
            label2.Name = "label2";
            label2.Size = new Size(184, 90);
            label2.TabIndex = 0;
            label2.Text = "Admin \r\nDashboard";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpLanguage
            // 
            grpLanguage.Controls.Add(ddLanguage);
            grpLanguage.Dock = DockStyle.Right;
            grpLanguage.Location = new Point(546, 0);
            grpLanguage.Name = "grpLanguage";
            grpLanguage.Size = new Size(186, 60);
            grpLanguage.TabIndex = 2;
            grpLanguage.TabStop = false;
            grpLanguage.Text = "Language";
            // 
            // ddLanguage
            // 
            ddLanguage.Cursor = Cursors.Hand;
            ddLanguage.Dock = DockStyle.Fill;
            ddLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            ddLanguage.FormattingEnabled = true;
            ddLanguage.Location = new Point(3, 25);
            ddLanguage.Name = "ddLanguage";
            ddLanguage.Size = new Size(180, 29);
            ddLanguage.TabIndex = 0;
            ddLanguage.SelectedIndexChanged += ddLanguage_SelectedIndexChanged;
            // 
            // dbAdmin
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 556);
            Margin = new Padding(5);
            Name = "dbAdmin";
            Text = "Admin Dashboard";
            pnlLeft.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            pnlTopRight.ResumeLayout(false);
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            pnlDetails.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            grpLanguage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnEmployees;
        private Label label2;
        private Button btnLanguages;
        private Button btnTranslations;
        private GroupBox grpLanguage;
        private ComboBox ddLanguage;
    }
}