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
    public partial class view_books : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\haris\Documents\library_management.mdf;Integrated Security=True;Connect Timeout=30");
        public view_books()
        {
            InitializeComponent();
            updateBooksPanel.Visible = false;
        }

        private void view_books_Load(object sender, EventArgs e)
        {
            display_books();
        }

        //private void searchBooksBtn_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand cmd = conn.CreateCommand();
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = "select * from books_info where books_name like ('%" + booksNameTxt.Text + "%')";
        //        cmd.ExecuteNonQuery();
        //        DataTable dt = new DataTable();
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        da.Fill(dt);
        //        booksGridView.DataSource = dt;
        //        conn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, (""), MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void booksNameTxt_KeyUp(object sender, KeyEventArgs e)
        {
            //int i = 0;
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from books_info where books_name like ('%" + booksNameTxt.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                //i = Convert.ToInt32(dt.Rows.Count.ToString());
                booksGridView.DataSource = dt;
                conn.Close();

                //if(i == 0)
                //{
                //    MessageBox.Show("Books Not Found!!!");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, (""), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void searchAuthorBtn_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand cmd = conn.CreateCommand();
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = "select * from books_info where books_author_name like ('%" + authorNameTxt.Text + "%')";
        //        cmd.ExecuteNonQuery();
        //        DataTable dt = new DataTable();
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        da.Fill(dt);
        //        booksGridView.DataSource = dt;
        //        conn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, (""), MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void authorNameTxt_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from books_info where books_author_name like ('%" + authorNameTxt.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                booksGridView.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, (""), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void booksGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateBooksPanel.Visible = true;
            int i;
            i = Convert.ToInt32(booksGridView.SelectedCells[0].Value.ToString());
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from books_info where id = "+ i +"";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach(DataRow dataRow in dt.Rows)
                {
                    booksNameTextBx.Text = dataRow["books_name"].ToString();
                    booksAuthorNameTextBx.Text = dataRow["books_author_name"].ToString();
                    booksPublicationNameTextBx.Text = dataRow["books_publication_name"].ToString();
                    booksPurchaseDateDtPckr.Value = Convert.ToDateTime(dataRow["books_purchase_date"].ToString());
                    booksPriceTextBx.Text = dataRow["books_price"].ToString();
                    booksQuantityTextBx.Text = dataRow["books_quantity"].ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, (""), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(booksGridView.SelectedCells[0].Value.ToString());

            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update books_info set books_name ='"+ booksNameTextBx.Text +"', books_author_name = '"+ booksAuthorNameTextBx.Text +"', books_publication_name = '"+ booksPublicationNameTextBx.Text +"', books_purchase_date = '"+ booksPurchaseDateDtPckr.Text +"', books_price = '"+ booksPriceTextBx.Text +"', books_quantity = '"+ booksQuantityTextBx.Text +"' where id = "+ i +"";
                cmd.ExecuteNonQuery();
                conn.Close();
                display_books();
                MessageBox.Show("Record updated successfully", (""), MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateBooksPanel.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, (""), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void display_books()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from books_info";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                booksGridView.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, (""), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
