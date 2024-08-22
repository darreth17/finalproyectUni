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
using System.Data.SqlClient;
using datos;
using System.Runtime.CompilerServices;

namespace proyectofinal
{
    public partial class menuventas : Form
    {
        /*
        //creo un objeto para llamar los metodos
        metodosventas ab = new metodosventas();
        */
        metodoscliente mos = new metodoscliente();
        metodosinventario mosi= new metodosinventario();
        metodosventas meven = new metodosventas();
        public menuventas()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtclitcorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
           
           double canavender= int.Parse (txtcantidadavender.Text);
           double canti = int.Parse (txtcanti.Text);
           double preciou = int.Parse (txtpreciou.Text);
           double total,cantiresta;
            
           
            
            
           if ( canti < canavender  || txtapellidos.Text.Equals("") ||txtproducto.Text.Equals("") || txtpreciou.Text.Equals("") || txtnombre.Text.Equals("") || txtidentificaciondelcli.Text.Equals("")
               || txtcoproducto.Text.Equals("") || txtcanti.Text.Equals("") || txtcantidadavender.Text.Equals(""))
           {

                MessageBox.Show("inserte el cliente, el producto y la candidad a vender");


           }
           else 
           {
                total = canavender * preciou;
                cantiresta = canti - canavender;
                txtcanti.Text = cantiresta.ToString();
                txttotal.Text = total.ToString();
                conexion.conectar();
                SqlCommand modificar = new SqlCommand("UPDATE inventario SET existencia=@vexistencia where codigo=@vcodigo and nombredelarticulo=@vnombredelarticulo ", conexion.conectar());
                modificar.Parameters.AddWithValue("@vexistencia", txtcanti.Text);
                modificar.Parameters.AddWithValue("@vcodigo", txtcoproducto.Text);
                modificar.Parameters.AddWithValue("@vnombredelarticulo", txtproducto.Text);
                modificar.ExecuteNonQuery();
             
                MessageBox.Show("el total a pagar es " + total );
                meven.guardarventa(new ventas(int.Parse(txtidentificaciondelcli.Text), int.Parse(txtcoproducto.Text), txtnombre.Text, txtproducto.Text, int.Parse(txtcantidadavender.Text), int.Parse(txttotal.Text)));
                txtcoproducto.Clear();
                txtcanti.Clear();
                txtcantidadavender.Clear();
                txtidentificaciondelcli .Clear ();
                txtapellidos.Clear ();
                txtnombre .Clear ();
                txttotal.Clear ();
                txtproducto.Clear ();
                txtpreciou.Clear ();
           }
            



        }

        private void btnmodificar_Click(object sender, EventArgs e)
        { 
           
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            //llamo el metodo para mostrar datos
            /*
            dataabogado.DataSource = ab.mostrardatos();
            */
        }

        private void btneleminar_Click(object sender, EventArgs e)
        {
          
        }

        private void dataabogado_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            //cuando hago clic en el encabezado de un dato del datagriw que me ponga todos los datos en los textbox
            
            txtnombre.Text = datacliente.SelectedRows[0].Cells[0].Value.ToString();
            txtapellidos.Text = datacliente.SelectedRows[0].Cells[1].Value.ToString();
            txtidentificaciondelcli.Text = datacliente.SelectedRows[0].Cells[2].Value.ToString();


        }


        private void volverAlMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuprincipal pri = new menuprincipal();
            pri.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscarcli_Click(object sender, EventArgs e)
        {
            
            datacliente.DataSource = mos.mostrardatos();
            
           
        }

        private void txtidentificaciondelcli_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtabocelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridinventario.DataSource = mosi.mostrardatos();
        }

        private void dataGridinventario_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtcoproducto.Text = dataGridinventario.SelectedRows[0].Cells[0].Value.ToString();
            txtproducto.Text = dataGridinventario.SelectedRows[0].Cells[1].Value.ToString();
            txtcanti.Text = dataGridinventario.SelectedRows[0].Cells[2].Value.ToString();
            txtpreciou.Text = dataGridinventario.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void registroDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registrodeventas p = new registrodeventas();
            p.Show ();
            this.Hide();  
        }
    }
}
