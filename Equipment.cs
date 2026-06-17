using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace gym_management_system
{
    public partial class Equipment : Form
    {
        // නිවැරදි අලුත් Database නම (Equipments) සහිත ලින්ක් එක
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Equipments;Integrated Security=True";

        public Equipment()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // මඟහැරී තිබුණු ප්‍රධාන පේළිය මෙන්න:
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO Equipment (EquipName, EDescription, MUsed, DDate, Cost) VALUES (@name, @desc, @muscle, @date, @cost)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", txtEquipName.Text);
                        cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                        cmd.Parameters.AddWithValue("@muscle", txtMusclesUsed.Text);
                        cmd.Parameters.AddWithValue("@date", dateTimePickerDeliveryDate.Value);
                        cmd.Parameters.AddWithValue("@cost", txtCost.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Equipment Data Saved Successfully!", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btnReset_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            ViewEquipment ve = new ViewEquipment();
            ve.Show();
        }
    }
}