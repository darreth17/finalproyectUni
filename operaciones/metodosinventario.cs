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
    public class metodosinventario
    {
        List<inventario> Listainventarios = new List<inventario>();

        public void agregarinventario (inventario expi)
        {
            //hago un metodo para guardar datos en las entidades,despues llamo esos datos con un objeto
            // y despues esos datos los guardo en la base de datos

            Listainventarios.Add(expi);
            conexion.conectar();
            string insertar = "INSERT INTO inventario (codigo,nombredelarticulo,descripcion,preciounitario,existencia) VALUES(@codigo,@nombredelarticulo,@descripcion,@preciounitario,@existencia)";

            SqlCommand guardar = new SqlCommand(insertar, conexion.conectar());

            guardar.Parameters.AddWithValue("@codigo", expi.Codigo);
            guardar.Parameters.AddWithValue("@nombredelarticulo", expi.Nombredelarticulo);
            guardar.Parameters.AddWithValue("@descripcion", expi.Descripcion);
            guardar.Parameters.AddWithValue("@preciounitario", expi.Preciounitario);
            guardar.Parameters.AddWithValue("@existencia", expi.Existencia);

            guardar.ExecuteNonQuery();

        }
        public void actualizarinventario(inventario expi)
        {
            //actualizo la base de datos usando el mismo metodo de arriba exceptuando que en ves de un insert uso un update
            Listainventarios.Add(expi);
            conexion.conectar();
            string actualizar = "UPDATE inventario SET codigo=@codigo ,nombredelarticulo=@nombredelarticulo ,descripcion=@descripcion ,preciounitario=@preciounitario ,existencia=@existencia WHERE codigo=@codigo";

            SqlCommand actu = new SqlCommand(actualizar, conexion.conectar());

            actu.Parameters.AddWithValue("@codigo", expi.Codigo);
            actu.Parameters.AddWithValue("@nombredelarticulo", expi.Nombredelarticulo);
            actu.Parameters.AddWithValue("@descripcion", expi.Descripcion);
            actu.Parameters.AddWithValue("@preciounitario", expi.Preciounitario);
            actu.Parameters.AddWithValue("@existencia", expi.Existencia);
            actu.ExecuteNonQuery();

        }
       
        //es un metodo para visualizar los datos de una base de datos
        public DataTable mostrardatos()
        {
            conexion.conectar();

            DataTable dtc = new DataTable();

            string consulta = "SELECT * from inventario";

            SqlCommand cmd = new SqlCommand(consulta, conexion.conectar());

            SqlDataAdapter cargar = new SqlDataAdapter(cmd);

            cargar.Fill(dtc);
            return dtc;


        }
        public void eliminarinventario(inventario ente)
        {
            //borro un dato de la base de datos
            conexion.conectar();
            string eliminar = "DELETE FROM inventario WHERE codigo=@codigo";

            SqlCommand borrar = new SqlCommand(eliminar, conexion.conectar());

            borrar.Parameters.AddWithValue("@codigo", ente.Codigo);

            borrar.ExecuteNonQuery();
            Listainventarios.Remove(ente);
        }


    }
}
