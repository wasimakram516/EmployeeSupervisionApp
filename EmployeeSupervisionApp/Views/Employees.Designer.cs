namespace EmployeeSupervisionApp.Views
{
    partial class Employees
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
            lblName = new Label();
            txtName = new TextBox();
            errName = new Label();
            errPosition = new Label();
            txtPosition = new TextBox();
            lblPosition = new Label();
            errEmail = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            errPhoneNumber = new Label();
            txtPhoneNumber = new TextBox();
            lblPhoneNumber = new Label();
            errPassword = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            errDepartment = new Label();
            txtDepartment = new TextBox();
            lblDepartment = new Label();
            errAddress = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            ddGender = new ComboBox();
            errGender = new Label();
            lblGender = new Label();
            errUserType = new Label();
            lblUserType = new Label();
            ddUserType = new ComboBox();
            dtpDateOfBirth = new DateTimePicker();
            lblDateOfBirth = new Label();
            lblDateOfJoining = new Label();
            dtpDateOfJoining = new DateTimePicker();
            lblIsActive = new Label();
            lblDateOfLeft = new Label();
            dtpDateOfLeft = new DateTimePicker();
            chkIsActive = new CheckBox();
            errDateOfJoining = new Label();
            errDateOfBirth = new Label();
            pnlLeft.SuspendLayout();
            pnlRight.SuspendLayout();
            pnlTopLeft.SuspendLayout();
            pnlTopRight.SuspendLayout();
            pnlForm.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Size = new Size(48, 29);
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderSize = 0;
            // 
            // pnlLeft
            // 
            pnlLeft.Size = new Size(445, 482);
            // 
            // pnlRight
            // 
            pnlRight.Location = new Point(445, 0);
            pnlRight.Size = new Size(355, 482);
            // 
            // pnlTopLeft
            // 
            pnlTopLeft.Size = new Size(445, 60);
            // 
            // pnlTopRight
            // 
            pnlTopRight.Size = new Size(355, 60);
            // 
            // pnlForm
            // 
            pnlForm.Controls.Add(chkIsActive);
            pnlForm.Controls.Add(lblDateOfLeft);
            pnlForm.Controls.Add(dtpDateOfLeft);
            pnlForm.Controls.Add(lblIsActive);
            pnlForm.Controls.Add(errDateOfJoining);
            pnlForm.Controls.Add(lblDateOfJoining);
            pnlForm.Controls.Add(dtpDateOfJoining);
            pnlForm.Controls.Add(errDateOfBirth);
            pnlForm.Controls.Add(lblDateOfBirth);
            pnlForm.Controls.Add(dtpDateOfBirth);
            pnlForm.Controls.Add(errUserType);
            pnlForm.Controls.Add(lblUserType);
            pnlForm.Controls.Add(ddUserType);
            pnlForm.Controls.Add(errGender);
            pnlForm.Controls.Add(lblGender);
            pnlForm.Controls.Add(ddGender);
            pnlForm.Controls.Add(errAddress);
            pnlForm.Controls.Add(txtAddress);
            pnlForm.Controls.Add(lblAddress);
            pnlForm.Controls.Add(errDepartment);
            pnlForm.Controls.Add(txtDepartment);
            pnlForm.Controls.Add(lblDepartment);
            pnlForm.Controls.Add(errPassword);
            pnlForm.Controls.Add(txtPassword);
            pnlForm.Controls.Add(lblPassword);
            pnlForm.Controls.Add(errPhoneNumber);
            pnlForm.Controls.Add(txtPhoneNumber);
            pnlForm.Controls.Add(lblPhoneNumber);
            pnlForm.Controls.Add(errEmail);
            pnlForm.Controls.Add(txtEmail);
            pnlForm.Controls.Add(lblEmail);
            pnlForm.Controls.Add(errPosition);
            pnlForm.Controls.Add(txtPosition);
            pnlForm.Controls.Add(lblPosition);
            pnlForm.Controls.Add(errName);
            pnlForm.Controls.Add(txtName);
            pnlForm.Controls.Add(lblName);
            pnlForm.Size = new Size(445, 422);
            // 
            // pnlDetails
            // 
            pnlDetails.Size = new Size(355, 422);
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 21);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 33);
            txtName.Name = "txtName";
            txtName.Size = new Size(207, 29);
            txtName.TabIndex = 0;
            // 
            // errName
            // 
            errName.AutoSize = true;
            errName.Location = new Point(202, 9);
            errName.Name = "errName";
            errName.Size = new Size(17, 21);
            errName.TabIndex = 2;
            errName.Text = "*";
            // 
            // errPosition
            // 
            errPosition.AutoSize = true;
            errPosition.Location = new Point(202, 231);
            errPosition.Name = "errPosition";
            errPosition.Size = new Size(17, 21);
            errPosition.TabIndex = 5;
            errPosition.Text = "*";
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(12, 255);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(207, 29);
            txtPosition.TabIndex = 8;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(12, 231);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(65, 21);
            lblPosition.TabIndex = 3;
            lblPosition.Text = "Position";
            // 
            // errEmail
            // 
            errEmail.AutoSize = true;
            errEmail.Location = new Point(202, 121);
            errEmail.Name = "errEmail";
            errEmail.Size = new Size(17, 21);
            errEmail.TabIndex = 8;
            errEmail.Text = "*";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 145);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(207, 29);
            txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 121);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 21);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // errPhoneNumber
            // 
            errPhoneNumber.AutoSize = true;
            errPhoneNumber.Location = new Point(202, 176);
            errPhoneNumber.Name = "errPhoneNumber";
            errPhoneNumber.Size = new Size(17, 21);
            errPhoneNumber.TabIndex = 11;
            errPhoneNumber.Text = "*";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(12, 200);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(207, 29);
            txtPhoneNumber.TabIndex = 6;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(12, 176);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(54, 21);
            lblPhoneNumber.TabIndex = 9;
            lblPhoneNumber.Text = "Phone";
            // 
            // errPassword
            // 
            errPassword.AutoSize = true;
            errPassword.Location = new Point(415, 121);
            errPassword.Name = "errPassword";
            errPassword.Size = new Size(17, 21);
            errPassword.TabIndex = 14;
            errPassword.Text = "*";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(225, 145);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(207, 29);
            txtPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(225, 121);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 21);
            lblPassword.TabIndex = 12;
            lblPassword.Text = "Password";
            // 
            // errDepartment
            // 
            errDepartment.AutoSize = true;
            errDepartment.Location = new Point(202, 286);
            errDepartment.Name = "errDepartment";
            errDepartment.Size = new Size(17, 21);
            errDepartment.TabIndex = 17;
            errDepartment.Text = "*";
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(12, 310);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(207, 29);
            txtDepartment.TabIndex = 9;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(12, 286);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(93, 21);
            lblDepartment.TabIndex = 15;
            lblDepartment.Text = "Department";
            // 
            // errAddress
            // 
            errAddress.AutoSize = true;
            errAddress.Location = new Point(415, 176);
            errAddress.Name = "errAddress";
            errAddress.Size = new Size(17, 21);
            errAddress.TabIndex = 20;
            errAddress.Text = "*";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(225, 200);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(207, 84);
            txtAddress.TabIndex = 7;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(225, 176);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(66, 21);
            lblAddress.TabIndex = 18;
            lblAddress.Text = "Address";
            // 
            // ddGender
            // 
            ddGender.Cursor = Cursors.Hand;
            ddGender.DropDownStyle = ComboBoxStyle.DropDownList;
            ddGender.FormattingEnabled = true;
            ddGender.Location = new Point(225, 33);
            ddGender.Name = "ddGender";
            ddGender.Size = new Size(207, 29);
            ddGender.TabIndex = 1;
            // 
            // errGender
            // 
            errGender.AutoSize = true;
            errGender.Location = new Point(415, 9);
            errGender.Name = "errGender";
            errGender.Size = new Size(17, 21);
            errGender.TabIndex = 23;
            errGender.Text = "*";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(225, 9);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(61, 21);
            lblGender.TabIndex = 22;
            lblGender.Text = "Gender";
            // 
            // errUserType
            // 
            errUserType.AutoSize = true;
            errUserType.Location = new Point(415, 64);
            errUserType.Name = "errUserType";
            errUserType.Size = new Size(17, 21);
            errUserType.TabIndex = 26;
            errUserType.Text = "*";
            // 
            // lblUserType
            // 
            lblUserType.AutoSize = true;
            lblUserType.Location = new Point(225, 64);
            lblUserType.Name = "lblUserType";
            lblUserType.Size = new Size(78, 21);
            lblUserType.TabIndex = 25;
            lblUserType.Text = "User Type";
            // 
            // ddUserType
            // 
            ddUserType.Cursor = Cursors.Hand;
            ddUserType.DropDownStyle = ComboBoxStyle.DropDownList;
            ddUserType.FormattingEnabled = true;
            ddUserType.Location = new Point(225, 88);
            ddUserType.Name = "ddUserType";
            ddUserType.Size = new Size(207, 29);
            ddUserType.TabIndex = 3;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(12, 88);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(207, 29);
            dtpDateOfBirth.TabIndex = 2;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new Point(12, 64);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(97, 21);
            lblDateOfBirth.TabIndex = 28;
            lblDateOfBirth.Text = "Date of Birth";
            // 
            // lblDateOfJoining
            // 
            lblDateOfJoining.AutoSize = true;
            lblDateOfJoining.Location = new Point(225, 287);
            lblDateOfJoining.Name = "lblDateOfJoining";
            lblDateOfJoining.Size = new Size(96, 21);
            lblDateOfJoining.TabIndex = 31;
            lblDateOfJoining.Text = "Joining Date";
            // 
            // dtpDateOfJoining
            // 
            dtpDateOfJoining.Location = new Point(225, 311);
            dtpDateOfJoining.Name = "dtpDateOfJoining";
            dtpDateOfJoining.Size = new Size(207, 29);
            dtpDateOfJoining.TabIndex = 10;
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.Location = new Point(12, 341);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(52, 21);
            lblIsActive.TabIndex = 34;
            lblIsActive.Text = "Status";
            // 
            // lblDateOfLeft
            // 
            lblDateOfLeft.AutoSize = true;
            lblDateOfLeft.Location = new Point(225, 341);
            lblDateOfLeft.Name = "lblDateOfLeft";
            lblDateOfLeft.Size = new Size(72, 21);
            lblDateOfLeft.TabIndex = 37;
            lblDateOfLeft.Text = "Left Date";
            // 
            // dtpDateOfLeft
            // 
            dtpDateOfLeft.Location = new Point(225, 365);
            dtpDateOfLeft.Name = "dtpDateOfLeft";
            dtpDateOfLeft.Size = new Size(207, 29);
            dtpDateOfLeft.TabIndex = 12;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(12, 365);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(86, 25);
            chkIsActive.TabIndex = 11;
            chkIsActive.Text = "Is Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // errDateOfJoining
            // 
            errDateOfJoining.AutoSize = true;
            errDateOfJoining.Location = new Point(415, 287);
            errDateOfJoining.Name = "errDateOfJoining";
            errDateOfJoining.Size = new Size(17, 21);
            errDateOfJoining.TabIndex = 32;
            errDateOfJoining.Text = "*";
            // 
            // errDateOfBirth
            // 
            errDateOfBirth.AutoSize = true;
            errDateOfBirth.Location = new Point(202, 64);
            errDateOfBirth.Name = "errDateOfBirth";
            errDateOfBirth.Size = new Size(17, 21);
            errDateOfBirth.TabIndex = 29;
            errDateOfBirth.Text = "*";
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 482);
            Name = "Employees";
            Text = "Employees";
            pnlLeft.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            pnlTopLeft.ResumeLayout(false);
            pnlTopRight.ResumeLayout(false);
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtName;
        private Label lblName;
        private Label errPosition;
        private TextBox txtPosition;
        private Label lblPosition;
        private Label errName;
        private Label errPassword;
        private TextBox txtPassword;
        private Label lblPassword;
        private Label errPhoneNumber;
        private TextBox txtPhoneNumber;
        private Label lblPhoneNumber;
        private Label errEmail;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label errAddress;
        private TextBox txtAddress;
        private Label lblAddress;
        private Label errDepartment;
        private TextBox txtDepartment;
        private Label lblDepartment;
        private Label errUserType;
        private Label lblUserType;
        private ComboBox ddUserType;
        private Label errGender;
        private Label lblGender;
        private ComboBox ddGender;
        private Label lblDateOfJoining;
        private DateTimePicker dtpDateOfJoining;
        private Label lblDateOfBirth;
        private DateTimePicker dtpDateOfBirth;
        private Label lblDateOfLeft;
        private DateTimePicker dtpDateOfLeft;
        private Label lblIsActive;
        private CheckBox chkIsActive;
        private Label errDateOfJoining;
        private Label errDateOfBirth;
    }
}