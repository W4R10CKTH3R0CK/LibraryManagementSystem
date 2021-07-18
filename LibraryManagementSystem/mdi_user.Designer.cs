﻿
namespace LibraryManagementSystem
{
    partial class mdi_user
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueBooksDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksStockInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remainBooksReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBooksToolStripMenuItem,
            this.viewBooksToolStripMenuItem,
            this.issueBooksDetailsToolStripMenuItem,
            this.returnBookDetailsToolStripMenuItem,
            this.booksStockInfoToolStripMenuItem});
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // addNewBooksToolStripMenuItem
            // 
            this.addNewBooksToolStripMenuItem.Name = "addNewBooksToolStripMenuItem";
            this.addNewBooksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewBooksToolStripMenuItem.Text = "Add New Books";
            this.addNewBooksToolStripMenuItem.Click += new System.EventHandler(this.addNewBooksToolStripMenuItem_Click);
            // 
            // viewBooksToolStripMenuItem
            // 
            this.viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
            this.viewBooksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewBooksToolStripMenuItem.Text = "View Books";
            this.viewBooksToolStripMenuItem.Click += new System.EventHandler(this.viewBooksToolStripMenuItem_Click);
            // 
            // issueBooksDetailsToolStripMenuItem
            // 
            this.issueBooksDetailsToolStripMenuItem.Name = "issueBooksDetailsToolStripMenuItem";
            this.issueBooksDetailsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.issueBooksDetailsToolStripMenuItem.Text = "Issue Book Details";
            this.issueBooksDetailsToolStripMenuItem.Click += new System.EventHandler(this.issueBooksDetailsToolStripMenuItem_Click);
            // 
            // returnBookDetailsToolStripMenuItem
            // 
            this.returnBookDetailsToolStripMenuItem.Name = "returnBookDetailsToolStripMenuItem";
            this.returnBookDetailsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.returnBookDetailsToolStripMenuItem.Text = "Return Book Details";
            this.returnBookDetailsToolStripMenuItem.Click += new System.EventHandler(this.returnBookDetailsToolStripMenuItem_Click);
            // 
            // booksStockInfoToolStripMenuItem
            // 
            this.booksStockInfoToolStripMenuItem.Name = "booksStockInfoToolStripMenuItem";
            this.booksStockInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.booksStockInfoToolStripMenuItem.Text = "Books Stock Info";
            this.booksStockInfoToolStripMenuItem.Click += new System.EventHandler(this.booksStockInfoToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentInfoToolStripMenuItem,
            this.viewStudentInfoToolStripMenuItem});
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.studentsToolStripMenuItem.Text = "Student";
            // 
            // addStudentInfoToolStripMenuItem
            // 
            this.addStudentInfoToolStripMenuItem.Name = "addStudentInfoToolStripMenuItem";
            this.addStudentInfoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.addStudentInfoToolStripMenuItem.Text = "Add Student Info";
            this.addStudentInfoToolStripMenuItem.Click += new System.EventHandler(this.addStudentInfoToolStripMenuItem_Click);
            // 
            // viewStudentInfoToolStripMenuItem
            // 
            this.viewStudentInfoToolStripMenuItem.Name = "viewStudentInfoToolStripMenuItem";
            this.viewStudentInfoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.viewStudentInfoToolStripMenuItem.Text = "View Student Info";
            this.viewStudentInfoToolStripMenuItem.Click += new System.EventHandler(this.viewStudentInfoToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remainBooksReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // remainBooksReportToolStripMenuItem
            // 
            this.remainBooksReportToolStripMenuItem.Name = "remainBooksReportToolStripMenuItem";
            this.remainBooksReportToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.remainBooksReportToolStripMenuItem.Text = "Remain Books Report";
            this.remainBooksReportToolStripMenuItem.Click += new System.EventHandler(this.remainBooksReportToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // mdi_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "mdi_user";
            this.Text = "mdi_user";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueBooksDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksStockInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remainBooksReportToolStripMenuItem;
    }
}



