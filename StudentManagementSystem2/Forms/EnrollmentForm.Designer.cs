namespace StudentManagementSystem2.Forms
{
    partial class EnrollmentForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvEnrollments = new System.Windows.Forms.DataGridView();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblStudent = new System.Windows.Forms.Label();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.lblEnrollmentDate = new System.Windows.Forms.Label();
            this.dtpEnrollmentDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollments)).BeginInit();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.txtSearch);
            this.pnlTop.Controls.Add(this.btnSearch);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1100, 60);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Enrollment Management";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSearch.Location = new System.Drawing.Point(650, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 30);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(910, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvEnrollments
            // 
            this.dgvEnrollments.AllowUserToAddRows = false;
            this.dgvEnrollments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEnrollments.BackgroundColor = System.Drawing.Color.White;
            this.dgvEnrollments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEnrollments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEnrollments.ColumnHeadersHeight = 34;
            this.dgvEnrollments.Location = new System.Drawing.Point(10, 66);
            this.dgvEnrollments.Name = "dgvEnrollments";
            this.dgvEnrollments.ReadOnly = true;
            this.dgvEnrollments.RowHeadersWidth = 62;
            this.dgvEnrollments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnrollments.Size = new System.Drawing.Size(724, 504);
            this.dgvEnrollments.TabIndex = 1;
            this.dgvEnrollments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnrollments_CellClick);
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.pnlForm.Controls.Add(this.lblStudent);
            this.pnlForm.Controls.Add(this.cmbStudent);
            this.pnlForm.Controls.Add(this.lblCourse);
            this.pnlForm.Controls.Add(this.cmbCourse);
            this.pnlForm.Controls.Add(this.lblGrade);
            this.pnlForm.Controls.Add(this.txtGrade);
            this.pnlForm.Controls.Add(this.lblEnrollmentDate);
            this.pnlForm.Controls.Add(this.dtpEnrollmentDate);
            this.pnlForm.Controls.Add(this.btnAdd);
            this.pnlForm.Controls.Add(this.btnUpdate);
            this.pnlForm.Controls.Add(this.btnDelete);
            this.pnlForm.Controls.Add(this.btnClear);
            this.pnlForm.Location = new System.Drawing.Point(740, 70);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(350, 500);
            this.pnlForm.TabIndex = 2;
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Arial", 9F);
            this.lblStudent.Location = new System.Drawing.Point(15, 15);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(139, 21);
            this.lblStudent.TabIndex = 0;
            this.lblStudent.Text = "Select Student *";
            // 
            // cmbStudent
            // 
            this.cmbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudent.Font = new System.Drawing.Font("Arial", 9F);
            this.cmbStudent.Location = new System.Drawing.Point(15, 33);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(320, 29);
            this.cmbStudent.TabIndex = 1;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Arial", 9F);
            this.lblCourse.Location = new System.Drawing.Point(15, 68);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(135, 21);
            this.lblCourse.TabIndex = 2;
            this.lblCourse.Text = "Select Course *";
            // 
            // cmbCourse
            // 
            this.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourse.Font = new System.Drawing.Font("Arial", 9F);
            this.cmbCourse.Location = new System.Drawing.Point(15, 86);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(320, 29);
            this.cmbCourse.TabIndex = 3;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Arial", 9F);
            this.lblGrade.Location = new System.Drawing.Point(15, 121);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(60, 21);
            this.lblGrade.TabIndex = 4;
            this.lblGrade.Text = "Grade";
            // 
            // txtGrade
            // 
            this.txtGrade.Font = new System.Drawing.Font("Arial", 9F);
            this.txtGrade.Location = new System.Drawing.Point(15, 139);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(320, 28);
            this.txtGrade.TabIndex = 5;
            // 
            // lblEnrollmentDate
            // 
            this.lblEnrollmentDate.AutoSize = true;
            this.lblEnrollmentDate.Font = new System.Drawing.Font("Arial", 9F);
            this.lblEnrollmentDate.Location = new System.Drawing.Point(15, 168);
            this.lblEnrollmentDate.Name = "lblEnrollmentDate";
            this.lblEnrollmentDate.Size = new System.Drawing.Size(138, 21);
            this.lblEnrollmentDate.TabIndex = 6;
            this.lblEnrollmentDate.Text = "Enrollment Date";
            // 
            // dtpEnrollmentDate
            // 
            this.dtpEnrollmentDate.Font = new System.Drawing.Font("Arial", 9F);
            this.dtpEnrollmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnrollmentDate.Location = new System.Drawing.Point(15, 192);
            this.dtpEnrollmentDate.Name = "dtpEnrollmentDate";
            this.dtpEnrollmentDate.Size = new System.Drawing.Size(320, 28);
            this.dtpEnrollmentDate.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(15, 240);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 35);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Enrollment";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(175, 240);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(160, 35);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update Enrollment";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(15, 285);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 35);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete Enrollment";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(175, 285);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 35);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // EnrollmentForm
            // 
            this.ClientSize = new System.Drawing.Size(1100, 580);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.dgvEnrollments);
            this.Controls.Add(this.pnlForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EnrollmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrollments - Student Management System";
            this.Load += new System.EventHandler(this.EnrollmentForm_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollments)).EndInit();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);

        }

        // Controls declaration
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvEnrollments;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label lblEnrollmentDate;
        private System.Windows.Forms.DateTimePicker dtpEnrollmentDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
    }
}