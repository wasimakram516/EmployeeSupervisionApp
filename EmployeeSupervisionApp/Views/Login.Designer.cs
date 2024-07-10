namespace EmployeeSupervisionApp.Views
{
    partial class Login
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
            txtUsername = new TextBox();
            label3 = new Label();
            errUsername = new Label();
            errPassword = new Label();
            label6 = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            label2 = new Label();
            pnlLeft.SuspendLayout();
            pnlRight.SuspendLayout();
            pnlTopRight.SuspendLayout();
            pnlForm.SuspendLayout();
            pnlDetails.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.Margin = new Padding(5);
            pnlLeft.Size = new Size(300, 652);
            // 
            // pnlRight
            // 
            pnlRight.Margin = new Padding(5);
            pnlRight.Size = new Size(928, 652);
            // 
            // pnlTopLeft
            // 
            pnlTopLeft.Margin = new Padding(5);
            // 
            // pnlTopRight
            // 
            pnlTopRight.Margin = new Padding(5);
            pnlTopRight.Size = new Size(928, 60);
            // 
            // pnlForm
            // 
            pnlForm.Controls.Add(btnLogin);
            pnlForm.Controls.Add(errPassword);
            pnlForm.Controls.Add(label6);
            pnlForm.Controls.Add(txtPassword);
            pnlForm.Controls.Add(errUsername);
            pnlForm.Controls.Add(label3);
            pnlForm.Controls.Add(txtUsername);
            pnlForm.Margin = new Padding(5);
            pnlForm.Size = new Size(300, 592);
            // 
            // pnlDetails
            // 
            pnlDetails.Controls.Add(label2);
            pnlDetails.Margin = new Padding(5);
            pnlDetails.Size = new Size(928, 592);
            // 
            // lblUserDetails
            // 
            lblUserDetails.Margin = new Padding(5, 0, 5, 0);
            lblUserDetails.Size = new Size(724, 60);
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(13, 239);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(278, 29);
            txtUsername.TabIndex = 0;
            txtUsername.Text = "admin@admin.com";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 214);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 1;
            label3.Text = "Email";
            // 
            // errUsername
            // 
            errUsername.AutoSize = true;
            errUsername.Location = new Point(274, 214);
            errUsername.Margin = new Padding(4, 0, 4, 0);
            errUsername.Name = "errUsername";
            errUsername.Size = new Size(17, 21);
            errUsername.TabIndex = 2;
            errUsername.Text = "*";
            errUsername.Visible = false;
            // 
            // errPassword
            // 
            errPassword.AutoSize = true;
            errPassword.Location = new Point(274, 273);
            errPassword.Margin = new Padding(4, 0, 4, 0);
            errPassword.Name = "errPassword";
            errPassword.Size = new Size(17, 21);
            errPassword.TabIndex = 5;
            errPassword.Text = "*";
            errPassword.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 273);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(76, 21);
            label6.TabIndex = 4;
            label6.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(13, 298);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(278, 29);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "@admin123";
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(13, 334);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(278, 39);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(928, 592);
            label2.TabIndex = 0;
            label2.Text = "Employee\r\nSupervision\r\nApp";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 652);
            Margin = new Padding(5);
            Name = "Login";
            Text = "Login";
            pnlLeft.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            pnlTopRight.ResumeLayout(false);
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            pnlDetails.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private TextBox txtUsername;
        private Label errPassword;
        private Label label6;
        private TextBox txtPassword;
        private Label errUsername;
        private Button btnLogin;
        private Label label2;
    }
}