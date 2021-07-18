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
    public partial class login : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\haris\Documents\library_management.mdf;Integrated Security=True;Connect Timeout=30");
        int count = 0;
        public login()
        {
            InitializeComponent();
            this.ActiveControl = usernameTxt;
            usernameTxt.Focus();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from library_person where username = '"+ usernameTxt.Text +"' and password = '"+ passwordTxt.Text +"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());

            if(count == 0)
            {
                MessageBox.Show("Username/Password does not match!!!");
                usernameTxt.Clear();
                passwordTxt.Clear();
            }
            else
            {
                this.Hide();
                mdi_user mu = new mdi_user();
                mu.Show();
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            if(conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
        }

        private void usernameTxt_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                passwordTxt.Focus();
            }
        }
    }
}
