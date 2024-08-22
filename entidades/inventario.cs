using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
     public class inventario
    {
        //declaro variables 
        private int codigo;
        private string nombredelarticulo;
        private string descripcion;
        private double preciounitario;
        private double existencia;

        //encapsulo campos y uso propiedad de las variables
        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombredelarticulo { get => nombredelarticulo; set => nombredelarticulo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Preciounitario { get => preciounitario; set => preciounitario = value; }
        public double  Existencia { get => existencia; set => existencia = value; }
        //hago una estructura con las variables
        public inventario (int codigo, string nombredelarticulo, string descripcion,double preciounitario, double existencia)
        {
            Codigo = codigo;
            Nombredelarticulo = nombredelarticulo;
            Descripcion = descripcion;
            Preciounitario = preciounitario;
            Existencia = existencia ;
        }
    }
}
