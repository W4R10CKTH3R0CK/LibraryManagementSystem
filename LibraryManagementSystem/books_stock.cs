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
using System.Net.Mail;
using System.Net;

namespace LibraryManagementSystem
{
    public partial class books_stock : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\haris\Documents\library_management.mdf;Integrated Security=True;Connect Timeout=30");
        public books_stock()
        {
            InitializeComponent();
        }

        private void books_stock_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            fill_books_info();
        }

        public void fill_books_info()
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select books_name, books_author_name, books_quantity, available_quantity from books_info";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string i;
            i = dataGridView1.SelectedCells[0].Value.ToString();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from issue_books where books_name = '" + i.ToString() + "' and book_return_date = ''";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void searchBooksTxt_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select books_name, books_author_name, books_quantity, available_quantity from books_info where books_name like ('%" + searchBooksTxt.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string i;
            i = dataGridView2.SelectedCells[6].Value.ToString();

            emailIdTxt.Text = i.ToString();
        }

        private void sendEmailBtn_Click(object sender, EventArgs e)
        {
            //SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            //smtp.EnableSsl = true;
            //smtp.UseDefaultCredentials = false;
            //smtp.Credentials = new NetworkCredential("janakiraman.p007@gmail.com", "H3CKTH3W0R1D007@ajay");
            ////MailMessage mail = new MailMessage("hackers.square007@gmail.com", emailIdTxt.Text, "This is for book return notice.", contentTxt.Text);
            //MailMessage mail = new MailMessage("janakiraman.p007@gmail.com", emailIdTxt.Text);

            //mail.Priority = MailPriority.High;
            //smtp.Send(mail);
            //MessageBox.Show("Mail Sent Successfully!!!", (""), MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                string smtpAddress = "smtp.gmail.com";
                int portNumber = 587;
                bool enableSSL = true;
                string emailFromAddress = "janakiraman.p007@gmail.com"; //Sender Email Address  
                string password = "H3CKTH3W0R1D007@ajay"; //Sender Password  
                string emailToAddress = emailIdTxt.Text; //Receiver Email Address  
                string subject = "Hello Student";
                string body = contentTxt.Text;

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(emailFromAddress);
                    mail.To.Add(emailToAddress);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = true;
                    //mail.Attachments.Add(new Attachment("D:\\TestFile.txt"));//--Uncomment this to send any attachment  
                    using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                    {
                        smtp.Credentials = new NetworkCredential(emailFromAddress, password);
                        smtp.EnableSsl = enableSSL;
                        smtp.Send(mail);
                        MessageBox.Show("Mail Sent Successfully!!!", (""), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

