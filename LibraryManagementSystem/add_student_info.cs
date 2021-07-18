using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class add_student_info : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\haris\Documents\library_management.mdf;Integrated Security=True;Connect Timeout=30");

        string pwd;
        string wanted_Path;
        public add_student_info()
        {
            InitializeComponent();
        }

        private void selectImageBtn_Click(object sender, EventArgs e)
        {
            pwd = Class1.GetRandomPassword(20);
            wanted_Path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            DialogResult result = openFileDialogBox.ShowDialog();
            openFileDialogBox.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";

            if(result == DialogResult.OK)
            {
                studentPicBox.ImageLocation = openFileDialogBox.FileName;
                studentPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void saveInfoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (studentNameTxt.Text == "" ||
                    studentEnrollmentNoTxt.Text == "" ||
                    studentDepartmentTxt.Text == "" ||
                    studentSemesterTxt.Text == "" ||
                    studentContactTxt.Text == "" ||
                    studentEmailTxt.Text == "")
                {
                    MessageBox.Show("Please fill all the details", (""), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string image_path;
                    File.Copy(openFileDialogBox.FileName, wanted_Path + "\\student_images\\" + pwd + ".jpg");
                    image_path = "student_images\\" + pwd + ".jpg";

                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into student_info values('" + studentNameTxt.Text + "','" + image_path.ToString() + "','" + studentEnrollmentNoTxt.Text + "','" + studentDepartmentTxt.Text + "','" + studentSemesterTxt.Text + "','" + studentContactTxt.Text + "','" + studentEmailTxt.Text + "')";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    
                    MessageBox.Show("Record Inserted Successfully", (""), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    studentNameTxt.Clear();
                    studentPicBox.Image.Dispose();
                    studentPicBox.Image = null;
                    studentEnrollmentNoTxt.Clear();
                    studentDepartmentTxt.Clear();
                    studentSemesterTxt.Clear();
                    studentContactTxt.Clear();
                    studentEmailTxt.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, (""), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
