using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using datos;
using System.Data.SqlClient;


namespace proyectofinal
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            conexion.conectar();
            SqlCommand consulta = new SqlCommand("SELECT usuario,contrasena from usuario where usuario=@vusuario AND contrasena=@vcontra", conexion.conectar());
            //hago un comando de slq que pide que verifique si el usuario y contraseña son iguales a los que escribieron
           //y si son iguales gana acceso al menu principal si no muestra un mensaje de error

            consulta.Parameters.AddWithValue("@vusuario", txtusu.Text);
            consulta.Parameters.AddWithValue("@vcontra", txtcontra.Text);

            SqlDataReader lea = consulta.ExecuteReader();

            if (lea.Read())
            {
                conexion.conectar().Close();
                menuprincipal pantalla = new menuprincipal();
                pantalla.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("contraseña o usuario incorrecto");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuusuario usu = new menuusuario();
            usu.Show();
            this.Hide();
        }

        private void cambiarLaContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menumantenimiento man = new menumantenimiento();
            man.Show();
            this.Hide();
        }
    }
}
