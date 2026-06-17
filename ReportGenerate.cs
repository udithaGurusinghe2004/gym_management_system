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
    public partial class ReportGenerate : Form
    {
        public ReportGenerate()
        {
            InitializeComponent();
        }

        private void ReportGenerate_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
        
            try
            {
                string path = ReportGenerate.GenerateStaffReport();
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(path) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not generate staff report: " + ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string GenerateStaffReport()
        {
            throw new NotImplementedException();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
          
            try
            {
                string path = ReportGenerate.GenerateMemberReport();
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(path) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not generate member report: " + ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string GenerateMemberReport()
        {
            throw new NotImplementedException();
        }
    }
    
    
}
