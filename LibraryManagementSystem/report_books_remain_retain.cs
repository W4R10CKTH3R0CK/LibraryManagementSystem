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
    public partial class report_books_remain_retain : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\haris\Documents\library_management.mdf;Integrated Security=True;Connect Timeout=30");
        public report_books_remain_retain()
        {
            InitializeComponent();
        }

        private void generateTextTxt_Click(object sender, EventArgs e)
        {
            DataSet1 ds = new DataSet1();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from issue_books where book_return_date = ''";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds.DataTable1);
            CrystalReport1 myreport = new CrystalReport1();
            myreport.SetDataSource(ds);
            crystalReportViewer.ReportSource = myreport;

        }

        private void report_books_remain_retain_Load(object sender, EventArgs e)
        {
            if(conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
        }
    }
}
