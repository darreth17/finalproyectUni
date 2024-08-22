using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using entidades;
using datos;
using operaciones;
namespace proyectofinal
{
    public partial class menuusuario : Form
    {
        metodoslogin gin = new metodoslogin();
        public menuusuario()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            login lo = new login();
            lo.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text.Equals("")|| txtemail.Text.Equals("")|| txtcontra.Text.Equals("")|| txtusuario.Text.Equals(""))
            {
                MessageBox.Show("llene los campos solicitados");
            }
            else
            {
                gin.baselogin(new login1(txtusuario.Text, txtcontra.Text, txtnombre.Text, txtemail.Text));
                MessageBox.Show("su usuario ha sido creado con exito");
                txtnombre.Clear();
                txtcontra.Clear();
                txtusuario.Clear();
                txtemail.Clear();
            }
        }

        private void volverAlLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login lo = new login();
            lo.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
