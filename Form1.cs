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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMember nm = new NewMember();
            nm.Show();
        }

        private void newStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStaff ns = new NewStaff();
            ns.Show();
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchMember sm = new SearchMember();
            sm.Show();
        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteMember dm = new DeleteMember();
            dm.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAccount aa= new AddAccount();
            aa.Show();
        }

        private void getmembertoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportGenerate rg = new ReportGenerate();
            rg.Show();
        }

        private void equpmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipments eq= new Equipments();
            eq.Show();
        }
    }
}
