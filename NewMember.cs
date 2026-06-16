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

            String dob = dateTimePickerDOB.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            String email = txtEmail.Text;
            String joindate = dateTimePickerJoinDate.Text;  
            String gymTime = comboBoxGymTime.Text;  
            String address = txtAddress.Text;   
            String membership = comboBoxMembership.Text;    


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-L9N7SQ3T;Initial Catalog=gym;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into NewMember (Fname,Lname,Gender,Dob,Mobile,Email,JoinDate,Gymtime,Maddress,MembershipTime) values ( '" + fname + "','" + lname + "','" + gender + "','" + dob + "','" + mobile + "','" + email + "','" + joindate + "','" + gymTime + "','" + address + "','" + membership + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS= new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data saved"); 

        }
    }
}
