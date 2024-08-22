using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class cliente
    {
        //declaro variables 
        private string nombre;
        private string apellidos;
        private int numerodetelefono;
        private string corroelectronico;
        private string direccion;
        private int identificacion;

        //encapsulo campos y uso propiedad de las variables

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Identificacion { get => identificacion; set => identificacion = value; }
        public string Corroelectronico { get => corroelectronico; set => corroelectronico = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Numerodetelefono { get => numerodetelefono; set => numerodetelefono = value; }


        //hago una estructura con las variables
        public cliente(string nombre, string apellidos, int identificacion, string corroelectronico, string direccion, int numerodetelefono)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Identificacion = identificacion;
            Numerodetelefono = numerodetelefono;
            Corroelectronico = corroelectronico;
            Direccion = direccion;
            
        }
        
    }  
}
