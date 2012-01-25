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
    public partial class ServiceDesk : Form
    {
        public ServiceDesk()
        {
            InitializeComponent();
        }

        private void buttonTrackTaxiDriver_Click(object sender, EventArgs e)
        {
           

            CabLocation CabLoc = new CabLocation();
            CabLoc.Show();
            
        }
                
    }
}
