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
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String uname = txtUsername.Text;
            String psswd = txtPassword.Text;
            String role = cmbrole.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-LSVNQANK\\SQLEXPRESS;Initial Catalog= GymManagementSystem;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM [User] WHERE UserName = @uname AND Password = @psswd AND Role = @role";

            cmd.Parameters.AddWithValue("@uname", uname);
            cmd.Parameters.AddWithValue("@psswd", psswd);
            cmd.Parameters.AddWithValue("@role", role);

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataTable DT = new DataTable();

            DA.Fill(DT);

            if (DT.Rows.Count > 0)
            {
                if (role == "owner")
                {
                    Form1 od = new Form1();
                    od.Show();
                }
                else if (role == "coach")
                {
                    //CoachDashboard coachForm = new CoachDashboard();
                    //coachForm.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login!");
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
