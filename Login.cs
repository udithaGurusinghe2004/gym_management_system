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
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                Form fm = new Form();
                fm.Show();
                this.Hide();
            }

            else 
            {
                MessageBox.Show("Incorrect Username or Password","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
