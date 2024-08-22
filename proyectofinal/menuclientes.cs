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
using entidades;
using operaciones;


namespace proyectofinal
{
    public partial class menuclientes : Form
    {
        //creo un objeto para llamar los metodos
        metodoscliente ope = new metodoscliente();
        public menuclientes()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            // si los campos estan vacios muestra un mensaje de llenar los campos
            if (txtclinombre.Text.Equals("") || txtcliapellidos.Text .Equals ("") || txtclinumdetelefon.Text.Equals("") ||
                txtclitcorreo.Text.Equals("") || txtclitnumedeiden.Text.Equals("") || txtclitdireccion.Text.Equals("") )
            {
                MessageBox.Show("llene los campos en blanco");

            }
            else
            {
                //llamo al metodo para guardar datos
                ope.basedecliente(new cliente(txtclinombre.Text, txtcliapellidos.Text, int.Parse(txtclinumdetelefon.Text),
                    txtclitcorreo.Text, txtclitdireccion.Text, int.Parse(txtclitnumedeiden.Text)));
                MessageBox.Show("los datos han sido guardados exitosamente");
                txtclinombre.Clear();
                txtcliapellidos.Clear();
                txtclinumdetelefon.Clear();
                txtclitcorreo.Clear();
                txtclitdireccion.Clear();
                txtclitnumedeiden.Clear();
                
            }

           
           

        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            //llamo el metodo para mostrar datos
            datacliente.DataSource = ope.mostrardatos();
        }

        private void datacliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
  
            try
            {
                txtclinombre.Text = datacliente.CurrentRow.Cells[0].Value.ToString();
                txtcliapellidos.Text = datacliente.CurrentRow.Cells[1].Value.ToString();
                txtclinumdetelefon.Text = datacliente.CurrentRow.Cells[2].Value.ToString();
                txtclitcorreo.Text = datacliente.CurrentRow.Cells[3].Value.ToString();
                txtclitdireccion.Text = datacliente.CurrentRow.Cells[4].Value.ToString();
                txtclitnumedeiden.Text = datacliente.CurrentRow.Cells[6].Value.ToString();
                txttipodeiden.Text = datacliente.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            */
        }

        private void datacliente_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //cuando hago clic en el encabezado de un dato del datagriw que me ponga todos los datos en los textbox
            txtclinombre.Text = datacliente.SelectedRows[0].Cells[0].Value.ToString();
            txtcliapellidos .Text = datacliente.SelectedRows[0].Cells[1].Value.ToString();
            txtclitnumedeiden.Text = datacliente.SelectedRows[0].Cells[2].Value.ToString();
            txtclitcorreo.Text = datacliente.SelectedRows[0].Cells[3].Value.ToString();
            txtclitdireccion.Text = datacliente.SelectedRows[0].Cells[4].Value.ToString();
            txtclinumdetelefon.Text = datacliente.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            //llamo al metodo de actulizar 
            ope.actualizarcliente(new cliente(txtclinombre.Text, txtcliapellidos.Text, int.Parse(txtclitnumedeiden.Text),
                    txtclitcorreo.Text, txtclitdireccion.Text, int.Parse(txtclinumdetelefon.Text)));
            MessageBox.Show("los datos han sido modificados exitosamente");
            txtclinombre.Clear();
            txtcliapellidos.Clear();
            txtclinumdetelefon.Clear();
            txtclitcorreo.Clear();
            txtclitdireccion.Clear();
            txtclitnumedeiden.Clear();
            datacliente.DataSource = ope.mostrardatos();
        }

        private void btneleminar_Click(object sender, EventArgs e)
        {
            //llamo al metodo de eliminar
            ope.eleminarcliente(new cliente(txtclinombre.Text, txtcliapellidos.Text, int.Parse(txtclitnumedeiden.Text),
                    txtclitcorreo.Text, txtclitdireccion.Text, int.Parse(txtclinumdetelefon.Text)));
            MessageBox.Show("los datos han sido eliminados exitosamente");
            txtclinombre.Clear();
            txtcliapellidos.Clear();
            txtclinumdetelefon.Clear();
            txtclitcorreo.Clear();
            txtclitdireccion.Clear();
            txtclitnumedeiden.Clear();
            datacliente.DataSource = ope.mostrardatos();
        }

        private void volverAlMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuprincipal pri = new menuprincipal();
            pri.Show();
            this.Hide();
        }
    }
}
