using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entidades;
using operaciones;
using datos;
using System.Data.SqlClient;

namespace proyectofinal
{
    public partial class menuinventario : Form
    {
        //creo un objeto para llamar los metodos
        metodosinventario ex = new metodosinventario();
        public menuinventario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            // si los campos estan vacios muestra un mensaje de llenar los campos
            if (txtnombre.Text.Equals("") || txtdescripcion.Text.Equals("") || txtcodigo.Text.Equals("") || txtexistencia.Text.Equals("") || txtprecio.Text.Equals(""))
            {
                MessageBox.Show("llene los campos en blanco");
            }
            else
            {
                //llamo al metodo para guardar datos 
                ex.agregarinventario(new inventario(int.Parse(txtcodigo.Text), txtnombre.Text, txtdescripcion.Text, double.Parse(txtprecio.Text), double.Parse(txtexistencia.Text)));
                MessageBox.Show("los datos han sido guardados exitosamente");
                txtdescripcion.Clear();
                txtnombre.Clear();
                txtcodigo.Clear();
                txtexistencia.Clear();
                txtprecio.Clear ();

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            //llamo el metodo para mostrar datos
            gridexpediente.DataSource = ex.mostrardatos();
        }

        private void menuexpediente_Load(object sender, EventArgs e)
        {

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            // si los campos estan vacios muestra un mensaje de llenar los campos
            if (txtnombre.Text.Equals("") || txtdescripcion.Text.Equals("") || txtcodigo.Text.Equals("") || txtexistencia.Text.Equals("") || txtprecio.Text.Equals(""))
            {
                MessageBox.Show("llene los campos en blanco");
            }
            else
            {
                //llamo al metodo de actulizar 
                ex.actualizarinventario (new inventario(int.Parse(txtcodigo.Text), txtnombre.Text, txtdescripcion.Text, double.Parse(txtprecio.Text), double.Parse(txtexistencia.Text)));
                MessageBox.Show("los datos han sido actualizados exitosamente");
                txtdescripcion.Clear();
                txtnombre.Clear();
                txtcodigo.Clear();
                txtprecio.Clear();
                txtexistencia.Clear();
                gridexpediente.DataSource = ex.mostrardatos();
            }
        }

        private void gridexpediente_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //cuando hago clic en el encabezado de un dato del datagriw que me ponga todos los datos en los textbox
            txtcodigo.Text = gridexpediente.SelectedRows[0].Cells[0].Value.ToString();
            txtnombre.Text = gridexpediente.SelectedRows[0].Cells[1].Value.ToString();
            txtexistencia   .Text = gridexpediente.SelectedRows[0].Cells[2].Value.ToString();
            txtprecio.Text = gridexpediente.SelectedRows[0].Cells[3].Value.ToString();
            txtdescripcion.Text = gridexpediente.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void btneleminar_Click(object sender, EventArgs e)
        {
            //llamo al metodo de eliminar
            ex.eliminarinventario (new inventario(int.Parse(txtcodigo.Text), txtnombre.Text, txtdescripcion.Text, double.Parse(txtprecio.Text), double.Parse(txtexistencia.Text)));
            MessageBox.Show("los datos han sido eleminados exitosamente");
            txtdescripcion.Clear();
            txtnombre.Clear();
            txtcodigo.Clear();
            txtexistencia.Clear();
            txtprecio.Clear();
            gridexpediente.DataSource = ex.mostrardatos();
        }

        private void volverAlMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuprincipal pri = new menuprincipal();
            pri.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
