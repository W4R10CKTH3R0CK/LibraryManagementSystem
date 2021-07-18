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
    public partial class issue_books : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\haris\Documents\library_management.mdf;Integrated Security=True;Connect Timeout=30");

        public issue_books()
        {
            InitializeComponent();
        }

        private void studentEnrollmentNoBtn_Click(object sender, EventArgs e)
        {
            int i = 0;
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from student_info where student_enrollment_no = '"+ enrollmentNoTxt.Text +"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if(i == 0)
            {
                MessageBox.Show("Enrollment Number Is Not Found", (""), MessageBoxButtons.OK, MessageBoxIcon.Error);
                studentNameTxt.Clear();
                studentDepartmentTxt.Clear();
                studentSemesterTxt.Clear();
                studentContactTxt.Clear();
                studentEmailTxt.Clear();
                booksNameTxt.Clear();
                booksNameLst.ClearSelected();
            }
            else
            {
                foreach(DataRow dr in dt.Rows)
                {
                    studentNameTxt.Text = dr["student_name"].ToString();
                    studentDepartmentTxt.Text = dr["student_department"].ToString();
                    studentSemesterTxt.Text = dr["student_sem"].ToString();
                    studentContactTxt.Text = dr["student_contact"].ToString();
                    studentEmailTxt.Text = dr["student_email"].ToString();
                }
            }
        }

        private void issue_books_Load(object sender, EventArgs e)
        {
            if(conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
        }

        private void booksNameTxt_KeyUp(object sender, KeyEventArgs e)
        {
            int count = 0;
            if(e.KeyCode != Keys.Enter)
            {
                booksNameLst.Items.Clear();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from books_info where books_name like('%"+ booksNameTxt.Text +"%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());

                if(count > 0)
                {
                    booksNameLst.Visible = true;
                    foreach(DataRow dr in dt.Rows)
                    {
                        booksNameLst.Items.Add(dr["books_name"]).ToString();
                    }
                }
            }

        }

        private void booksNameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                booksNameLst.Focus();
                booksNameLst.SelectedIndex = 0;
            }
        }

        private void booksNameLst_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                booksNameTxt.Text = booksNameLst.SelectedItem.ToString();
                booksNameLst.Visible = false;
            }
        }

        private void booksNameLst_MouseClick(object sender, MouseEventArgs e)
        {
            booksNameTxt.Text = booksNameLst.SelectedItem.ToString();
            booksNameLst.Visible = false;
        }

        private void issueBooksBtn_Click(object sender, EventArgs e)
        {
            int books_qty = 0;
            SqlCommand cmd2 = conn.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from books_info where books_name = '"+ booksNameTxt.Text +"'";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach(DataRow dr2 in dt2.Rows)
            {
                var quantity = dr2["available_quantity"].ToString();
                if(quantity.Equals(""))
                {
                    MessageBox.Show("Please check the available quantity!!!", (""), MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    books_qty = Convert.ToInt32(dr2["available_quantity"].ToString());
                }
            }

            if(books_qty > 0)
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into issue_books values('" + enrollmentNoTxt.Text + "','" + studentNameTxt.Text + "','" + studentDepartmentTxt.Text + "','" + studentSemesterTxt.Text + "','" + studentContactTxt.Text + "','" + studentEmailTxt.Text + "','" + booksNameTxt.Text + "','" + booksIssueDatePkr.Value.ToShortDateString() + "','')";
                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = conn.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update books_info set available_quantity=available_quantity-1 where books_name = '" + booksNameTxt.Text + "'";
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Books Issued Successfully", (""), MessageBoxButtons.OK, MessageBoxIcon.Information);

                enrollmentNoTxt.Clear();
                studentNameTxt.Clear();
                studentDepartmentTxt.Clear();
                studentSemesterTxt.Clear();
                studentContactTxt.Clear();
                studentEmailTxt.Clear();
                booksNameTxt.Clear();
                booksNameLst.ClearSelected();
            }
            else
            {
                MessageBox.Show("Books Not Available", (""), MessageBoxButtons.OK, MessageBoxIcon.Error);
                enrollmentNoTxt.Clear();
                studentNameTxt.Clear();
                studentDepartmentTxt.Clear();
                studentSemesterTxt.Clear();
                studentContactTxt.Clear();
                studentEmailTxt.Clear();
                booksNameTxt.Clear();
                booksNameLst.ClearSelected();
            }
        }
    }
}
