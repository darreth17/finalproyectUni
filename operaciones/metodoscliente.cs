using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using entidades;
using datos;
using System.Data.SqlClient;

namespace operaciones
{
    public class metodoscliente
    {
        List<cliente> listacliente = new List<cliente>();

      
     
        public List<cliente > retornarcliente()
        {
            return listacliente ;
        }
        public void   basedecliente (cliente clibas)
        {
            //hago un metodo para guardar datos en las entidades,despues llamo esos datos con un objeto
            // y despues esos datos los guardo en la base de datos
            listacliente.Add(clibas);
            conexion.conectar();
            string insertar = "INSERT INTO cliente (nombre,apellidos,identificacion,correoelectronico,direccion,numerodetelefono) VALUES(@nombre,@apellidos,@identificacion,@correoelectronico,@direccion,@numerodetelefono)";

            SqlCommand guardar = new SqlCommand(insertar, conexion.conectar());

            guardar.Parameters.AddWithValue("@nombre", clibas.Nombre);
            guardar.Parameters.AddWithValue("@apellidos", clibas.Apellidos);
            guardar.Parameters.AddWithValue("@identificacion", clibas.Identificacion);
            guardar.Parameters.AddWithValue("@correoelectronico", clibas.Corroelectronico);
            guardar.Parameters.AddWithValue("@direccion", clibas.Direccion);
            guardar.Parameters.AddWithValue("@numerodetelefono", clibas.Numerodetelefono);


            guardar.ExecuteNonQuery();

        }
        //es un metodo para visualizar los datos de una base de datos
        public DataTable mostrardatos()
        {
            conexion.conectar();

            DataTable dtc = new DataTable();

            string consulta = "SELECT nombre,apellidos,identificacion,correoelectronico,direccion,numerodetelefono from cliente";

            SqlCommand cmd = new SqlCommand(consulta, conexion.conectar());

            SqlDataAdapter cargar = new SqlDataAdapter(cmd);

            cargar.Fill(dtc);
            return dtc;


        }
        //actualizo la base de datos usando el mismo metodo de arriba exceptuando que en ves de un insert uso un update
        public void actualizarcliente(cliente clibas)
        {
            listacliente.Add(clibas);
            conexion.conectar();
            string modificar = "UPDATE cliente SET  nombre=@nombre ,apellidos=@apellidos ,identificacion=@identificacion ,correoelectronico=@correoelectronico ,direccion=@direccion,numerodetelefono=@numerodetelefono WHERE identificacion=@identificacion";

            SqlCommand guardar = new SqlCommand(modificar, conexion.conectar());

            guardar.Parameters.AddWithValue("@nombre", clibas.Nombre);
            guardar.Parameters.AddWithValue("@apellidos", clibas.Apellidos);
            guardar.Parameters.AddWithValue("@identificacion", clibas.Identificacion);
            guardar.Parameters.AddWithValue("@correoelectronico", clibas.Corroelectronico);
            guardar.Parameters.AddWithValue("@direccion", clibas.Direccion);
            guardar.Parameters.AddWithValue("@numerodetelefono", clibas.Numerodetelefono);


            guardar.ExecuteNonQuery();

        }
        public void eleminarcliente(cliente clibas)
        {
            //borro un dato de la base de datos
            conexion.conectar();
            string eliminar = "DELETE FROM cliente where identificacion=@identificacion";

            SqlCommand borrar = new SqlCommand(eliminar, conexion.conectar());

            borrar.Parameters.AddWithValue("@identificacion", clibas.Identificacion);

            borrar.ExecuteNonQuery();
            listacliente.Remove(clibas);
        }

     




    }
}
