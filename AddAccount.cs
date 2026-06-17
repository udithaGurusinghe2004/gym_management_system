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
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            txtUsername.Clear();
            txtpasswd.Clear();
            cmbrole.Items.Clear();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            String uname = txtUsername.Text;
            String psswd = txtpasswd.Text;
            String role = cmbrole.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-LSVNQANK\\SQLEXPRESS;Initial Catalog= GymManagementSystem;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;


            cmd.CommandText = "INSERT INTO [User] (UserName, Password, Role) VALUES (@uname, @psswd, @role)";

            cmd.Parameters.AddWithValue("@uname", uname);
            cmd.Parameters.AddWithValue("@psswd", psswd);
            cmd.Parameters.AddWithValue("@role", role);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("User added successfully!");
            Clear();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void closecirclebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
