
namespace LibraryManagementSystem
{
    partial class view_books
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
            this.booksGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.booksNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.authorNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updateBooksPanel = new System.Windows.Forms.Panel();
            this.booksPurchaseDateDtPckr = new System.Windows.Forms.DateTimePicker();
            this.updateBtn = new System.Windows.Forms.Button();
            this.booksQuantityTextBx = new System.Windows.Forms.TextBox();
            this.booksPriceTextBx = new System.Windows.Forms.TextBox();
            this.booksPublicationNameTextBx = new System.Windows.Forms.TextBox();
            this.booksAuthorNameTextBx = new System.Windows.Forms.TextBox();
            this.booksNameTextBx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.updateBooksPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // booksGridView
            // 
            this.booksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksGridView.Location = new System.Drawing.Point(397, 12);
            this.booksGridView.Name = "booksGridView";
            this.booksGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksGridView.Size = new System.Drawing.Size(845, 293);
            this.booksGridView.TabIndex = 0;
            this.booksGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksGridView_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.booksNameTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 72);
            this.panel1.TabIndex = 1;
            // 
            // booksNameTxt
            // 
            this.booksNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksNameTxt.Location = new System.Drawing.Point(166, 27);
            this.booksNameTxt.Name = "booksNameTxt";
            this.booksNameTxt.Size = new System.Drawing.Size(185, 26);
            this.booksNameTxt.TabIndex = 1;
            this.booksNameTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.booksNameTxt_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Books Name:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.authorNameTxt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 76);
            this.panel2.TabIndex = 2;
            // 
            // authorNameTxt
            // 
            this.authorNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorNameTxt.Location = new System.Drawing.Point(166, 27);
            this.authorNameTxt.Name = "authorNameTxt";
            this.authorNameTxt.Size = new System.Drawing.Size(185, 26);
            this.authorNameTxt.TabIndex = 1;
            this.authorNameTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.authorNameTxt_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Author Name:";
            // 
            // updateBooksPanel
            // 
            this.updateBooksPanel.Controls.Add(this.booksPurchaseDateDtPckr);
            this.updateBooksPanel.Controls.Add(this.updateBtn);
            this.updateBooksPanel.Controls.Add(this.booksQuantityTextBx);
            this.updateBooksPanel.Controls.Add(this.booksPriceTextBx);
            this.updateBooksPanel.Controls.Add(this.booksPublicationNameTextBx);
            this.updateBooksPanel.Controls.Add(this.booksAuthorNameTextBx);
            this.updateBooksPanel.Controls.Add(this.booksNameTextBx);
            this.updateBooksPanel.Controls.Add(this.label8);
            this.updateBooksPanel.Controls.Add(this.label7);
            this.updateBooksPanel.Controls.Add(this.label6);
            this.updateBooksPanel.Controls.Add(this.label5);
            this.updateBooksPanel.Controls.Add(this.label4);
            this.updateBooksPanel.Controls.Add(this.label3);
            this.updateBooksPanel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBooksPanel.Location = new System.Drawing.Point(99, 350);
            this.updateBooksPanel.Name = "updateBooksPanel";
            this.updateBooksPanel.Size = new System.Drawing.Size(1042, 291);
            this.updateBooksPanel.TabIndex = 3;
            // 
            // booksPurchaseDateDtPckr
            // 
            this.booksPurchaseDateDtPckr.Location = new System.Drawing.Point(815, 47);
            this.booksPurchaseDateDtPckr.Name = "booksPurchaseDateDtPckr";
            this.booksPurchaseDateDtPckr.Size = new System.Drawing.Size(215, 30);
            this.booksPurchaseDateDtPckr.TabIndex = 13;
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(501, 240);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(91, 30);
            this.updateBtn.TabIndex = 12;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // booksQuantityTextBx
            // 
            this.booksQuantityTextBx.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksQuantityTextBx.Location = new System.Drawing.Point(815, 169);
            this.booksQuantityTextBx.Name = "booksQuantityTextBx";
            this.booksQuantityTextBx.Size = new System.Drawing.Size(215, 30);
            this.booksQuantityTextBx.TabIndex = 11;
            // 
            // booksPriceTextBx
            // 
            this.booksPriceTextBx.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksPriceTextBx.Location = new System.Drawing.Point(815, 110);
            this.booksPriceTextBx.Name = "booksPriceTextBx";
            this.booksPriceTextBx.Size = new System.Drawing.Size(215, 30);
            this.booksPriceTextBx.TabIndex = 10;
            // 
            // booksPublicationNameTextBx
            // 
            this.booksPublicationNameTextBx.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksPublicationNameTextBx.Location = new System.Drawing.Point(248, 172);
            this.booksPublicationNameTextBx.Name = "booksPublicationNameTextBx";
            this.booksPublicationNameTextBx.Size = new System.Drawing.Size(215, 30);
            this.booksPublicationNameTextBx.TabIndex = 8;
            // 
            // booksAuthorNameTextBx
            // 
            this.booksAuthorNameTextBx.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksAuthorNameTextBx.Location = new System.Drawing.Point(248, 110);
            this.booksAuthorNameTextBx.Name = "booksAuthorNameTextBx";
            this.booksAuthorNameTextBx.Size = new System.Drawing.Size(215, 30);
            this.booksAuthorNameTextBx.TabIndex = 7;
            // 
            // booksNameTextBx
            // 
            this.booksNameTextBx.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksNameTextBx.Location = new System.Drawing.Point(248, 47);
            this.booksNameTextBx.Name = "booksNameTextBx";
            this.booksNameTextBx.Size = new System.Drawing.Size(215, 30);
            this.booksNameTextBx.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(594, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "Books Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(594, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Books Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(594, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Books Purchase Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Books Publication Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Books Author Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Books Name";
            // 
            // view_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 677);
            this.Controls.Add(this.updateBooksPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.booksGridView);
            this.Name = "view_books";
            this.Text = "view_books";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.view_books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.updateBooksPanel.ResumeLayout(false);
            this.updateBooksPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView booksGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox booksNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox authorNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel updateBooksPanel;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TextBox booksQuantityTextBx;
        private System.Windows.Forms.TextBox booksPriceTextBx;
        private System.Windows.Forms.TextBox booksPublicationNameTextBx;
        private System.Windows.Forms.TextBox booksAuthorNameTextBx;
        private System.Windows.Forms.TextBox booksNameTextBx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker booksPurchaseDateDtPckr;
    }
}