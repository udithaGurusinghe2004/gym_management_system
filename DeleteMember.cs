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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace gym_management_system
{
    public partial class DeleteMember : Form
    {
        public DeleteMember()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("This will delete your data. Confirm?", " Delete data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-LSVNQANK\\SQLEXPRESS;Initial Catalog= GymManagementSystem;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from Member where MID = " + textBox1.Text + "";


                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

            }

            else
            {
                this.Activate();
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-LSVNQANK\\SQLEXPRESS;Initial Catalog= GymManagementSystem;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from Member";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

            }
        }

        private void DeleteMember_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-LSVNQANK\\SQLEXPRESS;Initial Catalog= GymManagementSystem;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Member";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];
        }

        private void closecirclebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
