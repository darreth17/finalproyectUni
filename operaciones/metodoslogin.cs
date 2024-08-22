using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using entidades;
using datos;
namespace operaciones
{
    public class metodoslogin
    {
        List<login1 > lisalogin = new List<login1>();

        public void baselogin(login1 gin)
        {
            //hago un metodo para guardar datos en las entidades,despues llamo esos datos con un objeto
            // y despues esos datos los guardo en la base de datos
            lisalogin.Add(gin);
            conexion.conectar();
            string insertar = "INSERT INTO usuario (nombre,email,usuario,contrasena) values(@nombre,@email,@usuario,@contrasena)";

            SqlCommand guardar = new SqlCommand(insertar, conexion.conectar());
            guardar.Parameters.AddWithValue("@nombre", gin.Nombre);
            guardar.Parameters.AddWithValue("@email", gin.Email);
            guardar.Parameters.AddWithValue("@usuario", gin.Usuario);
            guardar.Parameters.AddWithValue("@contrasena", gin.Contraseña);

            guardar.ExecuteNonQuery();
        }

    }
}
