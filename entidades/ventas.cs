using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
     public class ventas
    {
        //declaro variables 
 
        private int numfactura;
        private int idencliente;
        private int codigoavender;
        private string nombrecliente;
        private string producto;
        private double  cantidadavender;
        private double total;
        //encapsulo campos y uso propiedad de las variable
        public int Numfactura { get => numfactura; set => numfactura = value; }
        public int Idencliente { get => idencliente; set => idencliente  = value; }
        public int Codigoavender { get => codigoavender; set => codigoavender = value; }
        public string Nombrecliente { get => nombrecliente ; set => nombrecliente = value; }
        public string Producto { get => producto ; set => producto = value; }
        public double  Cantidadavender { get => cantidadavender; set => cantidadavender = value; }
        public double  Total { get => total; set => total = value; }

        //hago una estructura con las variables
        public ventas (int idencliente,int codigoavender,string nombrecliente,string producto,double cantidadavender,double total)
        {

            
            Idencliente = idencliente;
            Codigoavender  = codigoavender;
            Nombrecliente  = nombrecliente;
            Producto = producto;
            Cantidadavender = cantidadavender;
            Total = total;
        }

    }
}
