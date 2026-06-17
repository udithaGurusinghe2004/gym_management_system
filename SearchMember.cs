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
    public partial class SearchMember : Form
    {
        public SearchMember()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtSearch.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-LSVNQANK\\SQLEXPRESS;Initial Catalog= GymManagementSystem;Integrated Security=True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewMember where MID = '" + txtSearch.Text + "'";

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

               // dataGridView1.DataSource = DS.Tables[0];
            }
            else
            {
                MessageBox.Show("Please enter some id", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void SearchMember_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-LSVNQANK\\SQLEXPRESS;Initial Catalog= GymManagementSystem;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewMember where MID = '" + txtSearch.Text + "'";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];
            
        }
    }
}
