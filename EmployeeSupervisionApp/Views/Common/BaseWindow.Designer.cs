namespace EmployeeSupervisionApp.Views.Common
{
    partial class BaseWindow
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
            pnlLeft = new Panel();
            pnlForm = new Panel();
            pnlTopLeft = new Panel();
            label1 = new Label();
            pnlRight = new Panel();
            pnlDetails = new Panel();
            pnlTopRight = new Panel();
            lblUserDetails = new Label();
            pnlLeft.SuspendLayout();
            pnlTopLeft.SuspendLayout();
            pnlRight.SuspendLayout();
            pnlTopRight.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(0, 64, 64);
            pnlLeft.Controls.Add(pnlForm);
            pnlLeft.Controls.Add(pnlTopLeft);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.ForeColor = Color.White;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Margin = new Padding(4);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(300, 630);
            pnlLeft.TabIndex = 0;
            // 
            // pnlForm
            // 
            pnlForm.Dock = DockStyle.Fill;
            pnlForm.Location = new Point(0, 60);
            pnlForm.Margin = new Padding(4);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(300, 570);
            pnlForm.TabIndex = 1;
            // 
            // pnlTopLeft
            // 
            pnlTopLeft.Controls.Add(label1);
            pnlTopLeft.Dock = DockStyle.Top;
            pnlTopLeft.Location = new Point(0, 0);
            pnlTopLeft.Margin = new Padding(4);
            pnlTopLeft.Name = "pnlTopLeft";
            pnlTopLeft.Size = new Size(300, 60);
            pnlTopLeft.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(166, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 60);
            label1.TabIndex = 0;
            label1.Text = "Welcome,";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlRight
            // 
            pnlRight.Controls.Add(pnlDetails);
            pnlRight.Controls.Add(pnlTopRight);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(300, 0);
            pnlRight.Margin = new Padding(4);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(730, 630);
            pnlRight.TabIndex = 1;
            // 
            // pnlDetails
            // 
            pnlDetails.Dock = DockStyle.Fill;
            pnlDetails.Location = new Point(0, 60);
            pnlDetails.Margin = new Padding(4);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Size = new Size(730, 570);
            pnlDetails.TabIndex = 2;
            // 
            // pnlTopRight
            // 
            pnlTopRight.Controls.Add(lblUserDetails);
            pnlTopRight.Dock = DockStyle.Top;
            pnlTopRight.Location = new Point(0, 0);
            pnlTopRight.Margin = new Padding(4);
            pnlTopRight.Name = "pnlTopRight";
            pnlTopRight.Size = new Size(730, 60);
            pnlTopRight.TabIndex = 0;
            // 
            // lblUserDetails
            // 
            lblUserDetails.Dock = DockStyle.Left;
            lblUserDetails.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserDetails.Location = new Point(0, 0);
            lblUserDetails.Margin = new Padding(4, 0, 4, 0);
            lblUserDetails.Name = "lblUserDetails";
            lblUserDetails.Size = new Size(438, 60);
            lblUserDetails.TabIndex = 1;
            lblUserDetails.Text = "User";
            lblUserDetails.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BaseWindow
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 630);
            ControlBox = false;
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MinimizeBox = false;
            Name = "BaseWindow";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            pnlLeft.ResumeLayout(false);
            pnlTopLeft.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            pnlTopRight.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        public Panel pnlLeft;
        public Panel pnlRight;
        public Panel pnlTopLeft;
        public Panel pnlTopRight;
        public Panel pnlForm;
        public Panel pnlDetails;
        public Label lblUserDetails;
    }
}