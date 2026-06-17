using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gym_management_system
{
    public partial class NewStaff : Form
    {
        public NewStaff()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String fname = txtFname.Text;
            String lname = txtLname.Text;
            String gender = "";
            bool isChecked = radioBtnMale.Checked;
            if (isChecked) { 
                gender = radioBtnMale.Text;
            }
            else
            {
                gender = radioBtnFemale.Text;
            }
            DateTime dob = dateTimePickerDOB.Value;
            String mobile = txtMobile.Text;
            String email = txtEmail.Text;
            DateTime hiredate = dateTimePickerHireDate.Value;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-LSVNQANK\\SQLEXPRESS;Initial Catalog= GymManagementSystem;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "INSERT INTO NewStaff(Fanme,Lname,Gender,DOB,Mobile,Email,HiredDate)" +
                "VALUES(@fname, @lname, @gender, @dob, @mobile, @email, @hiredate)";
            

            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue ("@lname", lname);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@mobile", mobile);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@hiredate", hiredate);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Clear();
        }
        public void Clear()
        {
            txtFname.Clear();
            txtLname.Clear();
            radioBtnFemale.Checked = false;
            radioBtnMale.Checked = false;
            txtMobile.Clear();
            txtEmail.Clear();

            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerHireDate.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
