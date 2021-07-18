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
using System.IO;

namespace LibraryManagementSystem
{
    public partial class view_student_info : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\haris\Documents\library_management.mdf;Integrated Security=True;Connect Timeout=30");
        DialogResult result;
        string pwd;
        string wanted_Path;
        public view_student_info()
        {
            InitializeComponent();
        }

        private void view_student_info_Load(object sender, EventArgs e)
        {
            if(conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            fill_grid();
        }

        public void fill_grid()
        {
            viewStudentInfoDataGrid.Columns.Clear();
            viewStudentInfoDataGrid.Refresh();
            int i = 0;
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from student_info";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            viewStudentInfoDataGrid.DataSource = dt;

            Bitmap img;
            DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
            imageCol.Width = 500;
            imageCol.HeaderText = "student image";
            imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imageCol.Width = 100;
            viewStudentInfoDataGrid.Columns.Add(imageCol);

            foreach (DataRow dr in dt.Rows)
            {
                img = new Bitmap(@"..\..\" + dr["student_image"].ToString());
                viewStudentInfoDataGrid.Rows[i].Cells[8].Value = img;
                viewStudentInfoDataGrid.Rows[i].Height = 100;
                i = i + 1;
            }
        }

        private void studentSearchTxt_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                viewStudentInfoDataGrid.Columns.Clear();
                viewStudentInfoDataGrid.Refresh();
                int i = 0;
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from student_info where student_name like('%"+ studentSearchTxt.Text +"%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                viewStudentInfoDataGrid.DataSource = dt;

                Bitmap img;
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                imageCol.Width = 500;
                imageCol.HeaderText = "student image";
                imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imageCol.Width = 100;
                viewStudentInfoDataGrid.Columns.Add(imageCol);

                foreach (DataRow dr in dt.Rows)
                {
                    img = new Bitmap(@"..\..\" + dr["student_image"].ToString());
                    viewStudentInfoDataGrid.Rows[i].Cells[8].Value = img;
                    viewStudentInfoDataGrid.Rows[i].Height = 100;
                    i = i + 1;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void viewStudentInfoDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Convert.ToInt32(viewStudentInfoDataGrid.SelectedCells[0].Value.ToString());

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from student_info where id = " + i + "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                studentNameTxt.Text = dr["student_name"].ToString();
                studentEnrollmentNoTxt.Text = dr["student_enrollment_no"].ToString();
                studentDepartmentTxt.Text = dr["student_department"].ToString();
                studentSemesterTxt.Text = dr["student_sem"].ToString();
                studentContactTxt.Text = dr["student_contact"].ToString();
                studentEmailTxt.Text = dr["student_email"].ToString();
            }
        }

        private void selectFileBtn_Click(object sender, EventArgs e)
        {
            pwd = Class1.GetRandomPassword(20);
            wanted_Path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            result = openFileDialogSelectFile.ShowDialog();
            openFileDialogSelectFile.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (result == DialogResult.OK)
            {
                int i;
                i = Convert.ToInt32(viewStudentInfoDataGrid.SelectedCells[0].Value.ToString());
                string image_path;
                File.Copy(openFileDialogSelectFile.FileName, wanted_Path + "\\student_images\\" + pwd + ".jpg");
                image_path = "student_images\\" + pwd + ".jpg";

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update student_info set student_name = '"+ studentNameTxt.Text +"', student_image = '"+ image_path.ToString() +"', student_enrollment_no = '"+ studentEnrollmentNoTxt.Text +"', student_department = '"+ studentEnrollmentNoTxt.Text +"', student_sem = '"+ studentSemesterTxt.Text +"', student_contact = '"+ studentContactTxt.Text +"', student_email = '"+ studentEmailTxt.Text +"' where id = " + i + "";
                cmd.ExecuteNonQuery();
                fill_grid();
                MessageBox.Show("Record Updated Successfully");

            }
            else if (result == DialogResult.Cancel)
            {
                int i;
                i = Convert.ToInt32(viewStudentInfoDataGrid.SelectedCells[0].Value.ToString());
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update student_info set student_name = '" + studentNameTxt.Text + "', student_enrollment_no = '" + studentEnrollmentNoTxt.Text + "', student_department = '" + studentEnrollmentNoTxt.Text + "', student_sem = '" + studentSemesterTxt.Text + "', student_contact = '" + studentContactTxt.Text + "', student_email = '" + studentEmailTxt.Text + "' where id = " + i + "";
                cmd.ExecuteNonQuery();
                fill_grid();
                MessageBox.Show("Record Updated Successfully");
            }
        }
    }
}
