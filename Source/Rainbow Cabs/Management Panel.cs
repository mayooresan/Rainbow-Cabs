﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rainbow_Cabs
{
    public partial class Management_Panel : Form
    {
        public Management_Panel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddVehicles vm = new AddVehicles();
            vm.Show();
        }

        private void Management_Panel_Load(object sender, EventArgs e)
        {

        }

        
    }
}
