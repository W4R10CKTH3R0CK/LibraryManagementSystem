
namespace LibraryManagementSystem
{
    partial class view_student_info
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
            this.viewStudentInfoDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.studentSearchTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.selectFileBtn = new System.Windows.Forms.Button();
            this.studentEmailTxt = new System.Windows.Forms.TextBox();
            this.studentContactTxt = new System.Windows.Forms.TextBox();
            this.studentSemesterTxt = new System.Windows.Forms.TextBox();
            this.studentDepartmentTxt = new System.Windows.Forms.TextBox();
            this.studentEnrollmentNoTxt = new System.Windows.Forms.TextBox();
            this.studentNameTxt = new System.Windows.Forms.TextBox();
            this.openFileDialogSelectFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.viewStudentInfoDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewStudentInfoDataGrid
            // 
            this.viewStudentInfoDataGrid.AllowUserToAddRows = false;
            this.viewStudentInfoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewStudentInfoDataGrid.Location = new System.Drawing.Point(442, 12);
            this.viewStudentInfoDataGrid.Name = "viewStudentInfoDataGrid";
            this.viewStudentInfoDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewStudentInfoDataGrid.Size = new System.Drawing.Size(965, 336);
            this.viewStudentInfoDataGrid.TabIndex = 0;
            this.viewStudentInfoDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewStudentInfoDataGrid_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Student Name:";
            // 
            // studentSearchTxt
            // 
            this.studentSearchTxt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentSearchTxt.Location = new System.Drawing.Point(181, 56);
            this.studentSearchTxt.Name = "studentSearchTxt";
            this.studentSearchTxt.Size = new System.Drawing.Size(234, 29);
            this.studentSearchTxt.TabIndex = 2;
            this.studentSearchTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.studentSearchTxt_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Controls.Add(this.selectFileBtn);
            this.panel1.Controls.Add(this.studentEmailTxt);
            this.panel1.Controls.Add(this.studentContactTxt);
            this.panel1.Controls.Add(this.studentSemesterTxt);
            this.panel1.Controls.Add(this.studentDepartmentTxt);
            this.panel1.Controls.Add(this.studentEnrollmentNoTxt);
            this.panel1.Controls.Add(this.studentNameTxt);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(442, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 338);
            this.panel1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(678, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(332, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Contact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Semester";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(678, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enrollment No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Student Name";
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(514, 242);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(81, 33);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // selectFileBtn
            // 
            this.selectFileBtn.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFileBtn.Location = new System.Drawing.Point(162, 243);
            this.selectFileBtn.Name = "selectFileBtn";
            this.selectFileBtn.Size = new System.Drawing.Size(107, 32);
            this.selectFileBtn.TabIndex = 6;
            this.selectFileBtn.Text = "Select File";
            this.selectFileBtn.UseVisualStyleBackColor = true;
            this.selectFileBtn.Click += new System.EventHandler(this.selectFileBtn_Click);
            // 
            // studentEmailTxt
            // 
            this.studentEmailTxt.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentEmailTxt.Location = new System.Drawing.Point(795, 153);
            this.studentEmailTxt.Name = "studentEmailTxt";
            this.studentEmailTxt.Size = new System.Drawing.Size(170, 30);
            this.studentEmailTxt.TabIndex = 5;
            // 
            // studentContactTxt
            // 
            this.studentContactTxt.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentContactTxt.Location = new System.Drawing.Point(470, 157);
            this.studentContactTxt.Name = "studentContactTxt";
            this.studentContactTxt.Size = new System.Drawing.Size(170, 30);
            this.studentContactTxt.TabIndex = 4;
            // 
            // studentSemesterTxt
            // 
            this.studentSemesterTxt.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentSemesterTxt.Location = new System.Drawing.Point(138, 159);
            this.studentSemesterTxt.Name = "studentSemesterTxt";
            this.studentSemesterTxt.Size = new System.Drawing.Size(170, 30);
            this.studentSemesterTxt.TabIndex = 3;
            // 
            // studentDepartmentTxt
            // 
            this.studentDepartmentTxt.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentDepartmentTxt.Location = new System.Drawing.Point(795, 41);
            this.studentDepartmentTxt.Name = "studentDepartmentTxt";
            this.studentDepartmentTxt.Size = new System.Drawing.Size(170, 30);
            this.studentDepartmentTxt.TabIndex = 2;
            // 
            // studentEnrollmentNoTxt
            // 
            this.studentEnrollmentNoTxt.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentEnrollmentNoTxt.Location = new System.Drawing.Point(470, 41);
            this.studentEnrollmentNoTxt.Name = "studentEnrollmentNoTxt";
            this.studentEnrollmentNoTxt.Size = new System.Drawing.Size(170, 30);
            this.studentEnrollmentNoTxt.TabIndex = 1;
            // 
            // studentNameTxt
            // 
            this.studentNameTxt.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameTxt.Location = new System.Drawing.Point(138, 43);
            this.studentNameTxt.Name = "studentNameTxt";
            this.studentNameTxt.Size = new System.Drawing.Size(170, 30);
            this.studentNameTxt.TabIndex = 0;
            // 
            // openFileDialogSelectFile
            // 
            this.openFileDialogSelectFile.FileName = "openFileDialog1";
            // 
            // view_student_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 714);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.studentSearchTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewStudentInfoDataGrid);
            this.Name = "view_student_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "view_student_info";
            this.Load += new System.EventHandler(this.view_student_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewStudentInfoDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewStudentInfoDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentSearchTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button selectFileBtn;
        private System.Windows.Forms.TextBox studentEmailTxt;
        private System.Windows.Forms.TextBox studentContactTxt;
        private System.Windows.Forms.TextBox studentSemesterTxt;
        private System.Windows.Forms.TextBox studentDepartmentTxt;
        private System.Windows.Forms.TextBox studentEnrollmentNoTxt;
        private System.Windows.Forms.TextBox studentNameTxt;
        private System.Windows.Forms.OpenFileDialog openFileDialogSelectFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}