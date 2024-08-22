using operaciones;
using System;
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
    public partial class registrodeventas : Form
    {
        metodosventas mos = new metodosventas();
        public registrodeventas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datagridventas.DataSource = mos.mostrardatos();
        }

        private void volverAlMenuVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuventas a = new menuventas();
            a.Show();
            this.Close();
        }
    }
}
