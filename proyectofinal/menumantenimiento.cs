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
using datos;
namespace proyectofinal
{
    public partial class menumantenimiento : Form
    {
        public menumantenimiento()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void volverAlLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login gin = new login();
            gin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.conectar();
            SqlCommand modificar = new SqlCommand("UPDATE usuario SET contrasena=@vcontra2 where usuario=@vusuario and contrasena=@vcontrasena ", conexion.conectar());
            modificar.Parameters.AddWithValue("@vcontra2", txtcontranueva.Text);
            modificar.Parameters.AddWithValue("@vcontrasena", txtcontravieja.Text);
            modificar.Parameters.AddWithValue("@vusuario", txtusuario.Text);
            modificar.ExecuteNonQuery();
            MessageBox.Show("su contraseña ha sido actualizada con exito");
            txtcontranueva.Clear();
            txtcontravieja.Clear();
            txtusuario.Clear();

        }
    }
}
