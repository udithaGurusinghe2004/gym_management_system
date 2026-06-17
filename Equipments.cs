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
    public partial class Equipments : Form
    {
        public Equipments()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            txtEquipName.Clear();
            txtDescription.Clear();
            txtMusclesUsed.Clear();
            txtCost.Clear();
            dateTimePickerDeliveryDate.Value = DateTime.Now;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string ename = txtEquipName.Text;
            string desc = txtDescription.Text;
            string mused = txtMusclesUsed.Text;
            DateTime pdate = dateTimePickerDeliveryDate.Value;
            Int64 cost = Int64.Parse(txtCost.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-LSVNQANK\\SQLEXPRESS;Initial Catalog= GymManagementSystem;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "INSERT INTO Equipment(EquipmentName, Description, MuscleUsed, PurchasedDate, Cost)" +
               "VALUES(@ename, @desc, @mused, @pdate, @cost)";

                cmd.Parameters.AddWithValue("@ename", ename);
                cmd.Parameters.AddWithValue("@desc", desc);
                cmd.Parameters.AddWithValue("@mused", mused);
                cmd.Parameters.AddWithValue("@pdate", pdate);
                cmd.Parameters.AddWithValue("@cost", cost);
                

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Clear();

                MessageBox.Show("Data saved.", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);

             
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnViewEq_Click(object sender, EventArgs e)
        {
            EquipmentView ev = new EquipmentView();
            ev.Show();
        }

        private void closecirclebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
