using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gym_management_system
{
    public partial class Equipments : Form
    {
        public Equipments()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string EquipName = txtEquipName.Text;
            string Description = txtDescription.Text;
            string MUsed = txtMusclesUsed.Text;
            string DDate = dateTimePickerDeliveryDate.Text;
            Int64 cost = Int64.Parse(txtCost.Text);

            /*
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Equipments;Integrated Security=True";

                string query = "INSERT INTO NewStaff (Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Statee, City) VALUES (@fname, @lname, @gender, @dob, @mobile, @email, @jdate, @state, @city)";

                using (SqlCommand cmd = new SqlCommand(query, con))
             {
                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                cmd.Parameters.AddWithValue("@gender", txtGender.Text);
                cmd.Parameters.AddWithValue("@dob", txtDob.Text);
                cmd.Parameters.AddWithValue("@mobile", txtMobile.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@jdate", txtJoinDate.Text);
                cmd.Parameters.AddWithValue("@state", txtState.Text);
                cmd.Parameters.AddWithValue("@city", txtCity.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
             }

                MessageBox.Show("Data saved.", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);

             */
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEquipName.Clear();
            txtDescription.Clear();
            txtMusclesUsed.Clear();
            txtCost.Clear();
            dateTimePickerDeliveryDate.Value = DateTime.Now;
        }

        private void btnViewEq_Click(object sender, EventArgs e)
        {

        }

        private void closecirclebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
