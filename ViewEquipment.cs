using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace gym_management_system
{
    public partial class ViewEquipment : Form
    {
        // 1. Connection String එක (මෙය නිවැරදිව භාවිතයට ගෙන ඇත)
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Equipments;Integrated Security=True";

        public ViewEquipment()
        {
            InitializeComponent();
        }

        // 2. ෆෝම් එක Load වන විට දත්ත පෙන්වීමේ කේතය
        private void ViewEquipment_Load(object sender, EventArgs e)
        {
            try
            {
                // මෙතැනදී 'con' නිවැරදිව නිර්මාණය කර connectionString එක භාවිතා කර ඇත.
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Equipment";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        // DataGridView එකට දත්ත සම්බන්ධ කිරීම
                        // (ඔයාගේ Grid එකේ නම dataGridView1 නොවේ නම්, ඒ නම මෙතැනට දෙන්න)
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}