
namespace LibraryManagementSystem
{
    partial class return_books
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchBooksBtn = new System.Windows.Forms.Button();
            this.enrollmentNoTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.booksGridView = new System.Windows.Forms.DataGridView();
            this.bookDetailsPanel = new System.Windows.Forms.Panel();
            this.returnBooksBtn = new System.Windows.Forms.Button();
            this.returnBookDatePkr = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.booksNameTxt = new System.Windows.Forms.TextBox();
            this.issueDateTxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).BeginInit();
            this.bookDetailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchBooksBtn);
            this.panel1.Controls.Add(this.enrollmentNoTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 148);
            this.panel1.TabIndex = 0;
            // 
            // searchBooksBtn
            // 
            this.searchBooksBtn.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBooksBtn.Location = new System.Drawing.Point(20, 97);
            this.searchBooksBtn.Name = "searchBooksBtn";
            this.searchBooksBtn.Size = new System.Drawing.Size(136, 30);
            this.searchBooksBtn.TabIndex = 2;
            this.searchBooksBtn.Text = "Search Books";
            this.searchBooksBtn.UseVisualStyleBackColor = true;
            this.searchBooksBtn.Click += new System.EventHandler(this.searchBooksBtn_Click);
            // 
            // enrollmentNoTxt
            // 
            this.enrollmentNoTxt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrollmentNoTxt.Location = new System.Drawing.Point(20, 62);
            this.enrollmentNoTxt.Name = "enrollmentNoTxt";
            this.enrollmentNoTxt.Size = new System.Drawing.Size(177, 29);
            this.enrollmentNoTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Enrollment No";
            // 
            // gridPanel
            // 
            this.gridPanel.Controls.Add(this.booksGridView);
            this.gridPanel.Location = new System.Drawing.Point(226, 13);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(994, 347);
            this.gridPanel.TabIndex = 1;
            this.gridPanel.Visible = false;
            // 
            // booksGridView
            // 
            this.booksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksGridView.Location = new System.Drawing.Point(3, 3);
            this.booksGridView.Name = "booksGridView";
            this.booksGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksGridView.Size = new System.Drawing.Size(988, 320);
            this.booksGridView.TabIndex = 0;
            this.booksGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksGridView_CellClick);
            // 
            // bookDetailsPanel
            // 
            this.bookDetailsPanel.Controls.Add(this.issueDateTxt);
            this.bookDetailsPanel.Controls.Add(this.booksNameTxt);
            this.bookDetailsPanel.Controls.Add(this.returnBooksBtn);
            this.bookDetailsPanel.Controls.Add(this.returnBookDatePkr);
            this.bookDetailsPanel.Controls.Add(this.label6);
            this.bookDetailsPanel.Controls.Add(this.label4);
            this.bookDetailsPanel.Controls.Add(this.label2);
            this.bookDetailsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookDetailsPanel.Location = new System.Drawing.Point(131, 378);
            this.bookDetailsPanel.Name = "bookDetailsPanel";
            this.bookDetailsPanel.Size = new System.Drawing.Size(1089, 236);
            this.bookDetailsPanel.TabIndex = 2;
            this.bookDetailsPanel.Visible = false;
            // 
            // returnBooksBtn
            // 
            this.returnBooksBtn.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBooksBtn.Location = new System.Drawing.Point(210, 149);
            this.returnBooksBtn.Name = "returnBooksBtn";
            this.returnBooksBtn.Size = new System.Drawing.Size(140, 31);
            this.returnBooksBtn.TabIndex = 6;
            this.returnBooksBtn.Text = "Return Books";
            this.returnBooksBtn.UseVisualStyleBackColor = true;
            this.returnBooksBtn.Click += new System.EventHandler(this.returnBooksBtn_Click);
            // 
            // returnBookDatePkr
            // 
            this.returnBookDatePkr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBookDatePkr.Location = new System.Drawing.Point(210, 85);
            this.returnBookDatePkr.Name = "returnBookDatePkr";
            this.returnBookDatePkr.Size = new System.Drawing.Size(221, 30);
            this.returnBookDatePkr.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Select Return Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(479, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Issue Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Books Name";
            // 
            // booksNameTxt
            // 
            this.booksNameTxt.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksNameTxt.Location = new System.Drawing.Point(210, 15);
            this.booksNameTxt.Name = "booksNameTxt";
            this.booksNameTxt.Size = new System.Drawing.Size(221, 30);
            this.booksNameTxt.TabIndex = 7;
            // 
            // issueDateTxt
            // 
            this.issueDateTxt.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueDateTxt.Location = new System.Drawing.Point(584, 15);
            this.issueDateTxt.Name = "issueDateTxt";
            this.issueDateTxt.Size = new System.Drawing.Size(221, 30);
            this.issueDateTxt.TabIndex = 8;
            // 
            // return_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 637);
            this.Controls.Add(this.bookDetailsPanel);
            this.Controls.Add(this.gridPanel);
            this.Controls.Add(this.panel1);
            this.Name = "return_books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "return_books";
            this.Load += new System.EventHandler(this.return_books_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).EndInit();
            this.bookDetailsPanel.ResumeLayout(false);
            this.bookDetailsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button searchBooksBtn;
        private System.Windows.Forms.TextBox enrollmentNoTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.DataGridView booksGridView;
        private System.Windows.Forms.Panel bookDetailsPanel;
        private System.Windows.Forms.Button returnBooksBtn;
        private System.Windows.Forms.DateTimePicker returnBookDatePkr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox issueDateTxt;
        private System.Windows.Forms.TextBox booksNameTxt;
    }
}