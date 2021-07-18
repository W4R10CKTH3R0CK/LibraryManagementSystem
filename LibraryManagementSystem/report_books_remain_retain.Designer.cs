
namespace LibraryManagementSystem
{
    partial class report_books_remain_retain
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
            this.generateTextTxt = new System.Windows.Forms.Button();
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // generateTextTxt
            // 
            this.generateTextTxt.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateTextTxt.Location = new System.Drawing.Point(738, 49);
            this.generateTextTxt.Name = "generateTextTxt";
            this.generateTextTxt.Size = new System.Drawing.Size(145, 34);
            this.generateTextTxt.TabIndex = 0;
            this.generateTextTxt.Text = "Generate Text";
            this.generateTextTxt.UseVisualStyleBackColor = true;
            this.generateTextTxt.Click += new System.EventHandler(this.generateTextTxt_Click);
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = -1;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.Location = new System.Drawing.Point(55, 138);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.Size = new System.Drawing.Size(1421, 536);
            this.crystalReportViewer.TabIndex = 1;
            // 
            // report_books_remain_retain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 711);
            this.Controls.Add(this.crystalReportViewer);
            this.Controls.Add(this.generateTextTxt);
            this.Name = "report_books_remain_retain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "report_books_remain_retain";
            this.Load += new System.EventHandler(this.report_books_remain_retain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generateTextTxt;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
    }
}