﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectofinal
{
    public partial class menuprincipal : Form
    {
        public menuprincipal()
        {
            InitializeComponent();
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            menuclientes cli = new menuclientes();
            cli.Show();
            this.Hide();
            
        }

        private void btabogados_Click(object sender, EventArgs e)
        {
            menuventas abo = new menuventas();
            abo.Show();
            this.Hide();
        }

        private void btexpedientes_Click(object sender, EventArgs e)
        {
            menuinventario expe = new menuinventario();
            expe.Show();
            this.Hide();
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void volverAlLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login gin = new login();
            gin.Show();
            this.Hide();
        }

        private void opcionesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
