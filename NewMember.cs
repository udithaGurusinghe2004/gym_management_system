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
    public partial class NewMember : Form
    {
        public NewMember()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;

            string gender = "";

            bool isChecked = radioButton1.Checked;

            if (isChecked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text; 
            }

            DateTime dob = dateTimePickerDOB.Value;
            String mobile =txtMobile.Text;
            String email = txtEmail.Text;
            DateTime joindate = dateTimePickerJoinDate.Value;  
            String gymTime = comboBoxGymTime.Text;  
            String address = txtAddress.Text;   
            String membership = comboBoxMembership.Text;    


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-LSVNQANK\\SQLEXPRESS;Initial Catalog= GymManagementSystem;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into Member(Fname,Lname,Gender,DOB,Mobile,Email,JoinDate,Gymtime,Address,MembershipTime)" +
                "VALUES(@fname, @lname, @gender, @dob, @mobile, @email, @joindate, @gymTime, @address, @membership)";

            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@mobile", mobile);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@joindate", joindate);
            cmd.Parameters.AddWithValue("@gymTime", gymTime);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@membership", membership);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data saved"); 

        }

        private void closecirclebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
