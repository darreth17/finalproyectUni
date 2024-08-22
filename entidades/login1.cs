using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class login1
    {
        //declaro variables 
        private string usuario;
        private string contraseña;
        private string nombre;
        private string email;
        //encapsulo campos y uso propiedad de las variables
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }
        //hago una estructura con las variables
        public login1(string usuario,string contraseña,string nombre,string email)
        {
            Usuario = usuario;
            Contraseña = contraseña;
            Nombre = nombre;
            Email = email;
        }


    }
}
