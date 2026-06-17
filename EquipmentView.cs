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
    public partial class EquipmentView : Form
    {
        public EquipmentView()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void EquipmentView_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(
                    "Data Source=LAPTOP-LSVNQANK\\SQLEXPRESS;Initial Catalog=GymManagementSystem;Integrated Security=True"
                );

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM Equipment";

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
