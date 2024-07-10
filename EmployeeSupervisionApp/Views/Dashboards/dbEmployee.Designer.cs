namespace EmployeeSupervisionApp.Views.Dashboards
{
    partial class dbEmployee
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
            pnlLeft.SuspendLayout();
            pnlRight.SuspendLayout();
            pnlTopRight.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.Margin = new Padding(5, 5, 5, 5);
            pnlLeft.Size = new Size(297, 556);
            // 
            // pnlRight
            // 
            pnlRight.Location = new Point(297, 0);
            pnlRight.Margin = new Padding(5, 5, 5, 5);
            pnlRight.Size = new Size(732, 556);
            // 
            // pnlTopLeft
            // 
            pnlTopLeft.Margin = new Padding(5, 5, 5, 5);
            pnlTopLeft.Size = new Size(297, 60);
            // 
            // pnlTopRight
            // 
            pnlTopRight.Margin = new Padding(5, 5, 5, 5);
            pnlTopRight.Size = new Size(732, 60);
            // 
            // pnlForm
            // 
            pnlForm.Margin = new Padding(5, 5, 5, 5);
            pnlForm.Size = new Size(297, 496);
            // 
            // pnlDetails
            // 
            pnlDetails.Margin = new Padding(5, 5, 5, 5);
            pnlDetails.Size = new Size(732, 496);
            // 
            // lblUserDetails
            // 
            lblUserDetails.Margin = new Padding(5, 0, 5, 0);
            lblUserDetails.Size = new Size(613, 60);
            // 
            // dbEmployee
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 556);
            Margin = new Padding(5, 5, 5, 5);
            Name = "dbEmployee";
            Text = "Employee Dashboard";
            pnlLeft.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            pnlTopRight.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}