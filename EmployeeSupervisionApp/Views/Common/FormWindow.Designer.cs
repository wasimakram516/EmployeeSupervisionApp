namespace EmployeeSupervisionApp.Views.Common
{
    partial class FormWindow
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnView = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            groupBox1 = new GroupBox();
            txtSearch = new TextBox();
            dataGV = new DataGridView();
            groupBox2 = new GroupBox();
            btnBack = new Button();
            pnlLeft.SuspendLayout();
            pnlRight.SuspendLayout();
            pnlTopLeft.SuspendLayout();
            pnlTopRight.SuspendLayout();
            pnlDetails.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGV).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.Margin = new Padding(5);
            pnlLeft.Size = new Size(300, 556);
            // 
            // pnlRight
            // 
            pnlRight.Margin = new Padding(5);
            pnlRight.Size = new Size(729, 556);
            // 
            // pnlTopLeft
            // 
            pnlTopLeft.Controls.Add(btnBack);
            pnlTopLeft.Margin = new Padding(5);
            pnlTopLeft.Controls.SetChildIndex(btnBack, 0);
            // 
            // pnlTopRight
            // 
            pnlTopRight.Margin = new Padding(5);
            pnlTopRight.Size = new Size(729, 60);
            // 
            // pnlForm
            // 
            pnlForm.AutoScroll = true;
            pnlForm.Margin = new Padding(5);
            pnlForm.Size = new Size(300, 496);
            // 
            // pnlDetails
            // 
            pnlDetails.Controls.Add(groupBox2);
            pnlDetails.Controls.Add(panel1);
            pnlDetails.Margin = new Padding(5);
            pnlDetails.Size = new Size(729, 496);
            // 
            // lblUserDetails
            // 
            lblUserDetails.Margin = new Padding(5, 0, 5, 0);
            lblUserDetails.Size = new Size(724, 60);
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(729, 65);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Controls.Add(btnView, 4, 0);
            tableLayoutPanel1.Controls.Add(btnDelete, 3, 0);
            tableLayoutPanel1.Controls.Add(btnSave, 2, 0);
            tableLayoutPanel1.Controls.Add(btnEdit, 1, 0);
            tableLayoutPanel1.Controls.Add(btnAdd, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 5, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(729, 65);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnView
            // 
            btnView.Dock = DockStyle.Fill;
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.Image = Properties.Resources.icons8_refresh_48;
            btnView.ImageAlign = ContentAlignment.MiddleLeft;
            btnView.Location = new Point(487, 3);
            btnView.Name = "btnView";
            btnView.Size = new Size(115, 59);
            btnView.TabIndex = 4;
            btnView.Text = "View";
            btnView.TextAlign = ContentAlignment.MiddleRight;
            btnView.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Image = Properties.Resources.icons8_delete_shield_48;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(366, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 59);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Image = Properties.Resources.icons8_tick_box_481;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(245, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(115, 59);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Image = Properties.Resources.icons8_pencil_drawing_48;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(124, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(115, 59);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.TextAlign = ContentAlignment.MiddleRight;
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Image = Properties.Resources.icons8_add_48;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 59);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(608, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(118, 59);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Location = new Point(3, 25);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(112, 29);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dataGV
            // 
            dataGV.AllowUserToAddRows = false;
            dataGV.AllowUserToDeleteRows = false;
            dataGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGV.BackgroundColor = Color.White;
            dataGV.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGV.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = "-";
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 64, 64);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGV.DefaultCellStyle = dataGridViewCellStyle3;
            dataGV.Dock = DockStyle.Fill;
            dataGV.Location = new Point(3, 25);
            dataGV.Name = "dataGV";
            dataGV.ReadOnly = true;
            dataGV.RowHeadersVisible = false;
            dataGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGV.Size = new Size(723, 403);
            dataGV.TabIndex = 1;
            dataGV.CellClick += dataGV_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGV);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 65);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(729, 431);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Details";
            // 
            // btnBack
            // 
            btnBack.Dock = DockStyle.Left;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Image = Properties.Resources.back_wite;
            btnBack.ImageAlign = ContentAlignment.MiddleLeft;
            btnBack.Location = new Point(0, 0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(81, 60);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.TextAlign = ContentAlignment.MiddleRight;
            btnBack.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // FormWindow
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 556);
            Margin = new Padding(5);
            Name = "FormWindow";
            pnlLeft.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            pnlTopLeft.ResumeLayout(false);
            pnlTopRight.ResumeLayout(false);
            pnlDetails.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGV).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        protected Button btnAdd;
        protected Button btnView;
        protected Button btnDelete;
        protected Button btnSave;
        protected Button btnEdit;
        private GroupBox groupBox1;
        protected TextBox txtSearch;
        private GroupBox groupBox2;
        public DataGridView dataGV;
        protected Button btnBack;
    }
}