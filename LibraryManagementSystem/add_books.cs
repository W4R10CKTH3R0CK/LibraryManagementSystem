using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class add_books : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\haris\Documents\library_management.mdf;Integrated Security=True;Connect Timeout=30");

        public add_books()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(booksNameTxt.Text == "" ||
                    booksAuthorNameTxt.Text == "" ||
                    booksPublicationTxt.Text == "" ||
                    booksPurchaseDateTxt.Text == "" ||
                    booksPriceTxt.Text == "" ||
                    booksQuantityTxt.Text == "")
                {
                    MessageBox.Show("Please fill all the details",("TextBox Validation"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "insert into books_info values('" + booksNameTxt.Text + "','" + booksAuthorNameTxt.Text + "','" + booksPublicationTxt.Text + "','" + booksPurchaseDateTxt.Text + "'," + booksPriceTxt.Text + "," + booksQuantityTxt.Text + ", "+ booksQuantityTxt.Text + ")";
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    booksNameTxt.Clear();
                    booksAuthorNameTxt.Clear();
                    booksPublicationTxt.Clear();

                    booksPriceTxt.Clear();
                    booksQuantityTxt.Clear();

                    MessageBox.Show("Books Added Successfully",(""), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
