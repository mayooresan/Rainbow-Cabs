using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rainbow_Cabs
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            //mock validation
            if (UserNametextBox.Text == String.Empty || PasswordtextBox.Text == String.Empty)
            {
                MessageBox.Show("Please enter the User Name and Password", "User Name or Password Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //ServiceDesk servicedeskfrm = new ServiceDesk();
            //servicedeskfrm.Show();

            Management_Panel managementPanel = new Management_Panel();
            managementPanel.Show();
            this.Hide();

           
        }
    }
}
