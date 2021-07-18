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
    public partial class return_books : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\haris\Documents\library_management.mdf;Integrated Security=True;Connect Timeout=30");

        public return_books()
        {
            InitializeComponent();
        }

        private void searchBooksBtn_Click(object sender, EventArgs e)
        {
            gridPanel.Visible = true;
            fill_grid(enrollmentNoTxt.Text);
        }

        private void return_books_Load(object sender, EventArgs e)
        {
            if(conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
        }

        public void fill_grid(string enrollmentNo)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from issue_books where student_enrollment_no = '"+ enrollmentNo.ToString() +"' and book_return_date = ''";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            booksGridView.DataSource = dt;
        }

        private void booksGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bookDetailsPanel.Visible = true;
                int i;
                i = Convert.ToInt32(booksGridView.SelectedCells[0].Value.ToString());
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from issue_books where Id = " + i + "";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    booksNameTxt.Text = dr["books_name"].ToString();
                    issueDateTxt.Text = dr["books_issue_date"].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please select the row with the data!!", (""), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void returnBooksBtn_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(booksGridView.SelectedCells[0].Value.ToString());

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update issue_books set book_return_date = '"+ returnBookDatePkr.Value.ToString() +"' where Id = "+ i +"";
            cmd.ExecuteNonQuery();

            SqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "update books_info set available_quantity = available_quantity + 1";
            cmd1.ExecuteNonQuery();

            MessageBox.Show("Books Return Successfully",("") ,MessageBoxButtons.OK, MessageBoxIcon.Information);
            bookDetailsPanel.Visible = true;
            fill_grid(enrollmentNoTxt.Text);

            booksNameTxt.Clear();
            issueDateTxt.Clear();

        }
    }
}
