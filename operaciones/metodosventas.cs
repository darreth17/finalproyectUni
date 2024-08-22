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
    public class metodosventas
    {
        List<ventas> Listaventas = new List<ventas>();
        public void guardarventa(ventas abo)
        { 
            
            //hago un metodo para guardar datos en las entidades,despues llamo esos datos con un objeto
            // y despues esos datos los guardo en la base de datos
            Listaventas.Add(abo);
            conexion.conectar();
            string insertar = "INSERT INTO venta" +
                "(indecliente,nombrecliente,codigoproducto,producto,cantidadavender,total)" +
                "values (@indecliente,@nombrecliente,@codigoproducto,@producto,@cantidadavender,@total) ";
            SqlCommand guardar = new SqlCommand(insertar, conexion.conectar());
            guardar.Parameters.AddWithValue("@indecliente", abo.Idencliente);
            guardar.Parameters.AddWithValue("@nombrecliente", abo.Nombrecliente);
            guardar.Parameters.AddWithValue("@codigoproducto", abo.Codigoavender);
            guardar.Parameters.AddWithValue("@producto", abo.Producto);
            guardar.Parameters.AddWithValue("@cantidadavender", abo.Cantidadavender);
            guardar.Parameters.AddWithValue("@total", abo.Total);
 
            guardar.ExecuteNonQuery();
            
        }
        
        //actualizo la base de datos usando el mismo metodo de arriba exceptuando que en ves de un insert uso un update
        public void actualizarventa(ventas abo)
        {
            
            Listaventas.Add(abo);
            conexion.conectar();
            string modificar = "UPDATE venta SET indecliente=@indecliente,nombrecliente=@nombrecliente,codigoproducto=@codigoproducto,producto=@producto,cantidadavender=@cantidadavender,total=@total";

            SqlCommand actualizar = new SqlCommand(modificar, conexion.conectar());

            actualizar.Parameters.AddWithValue("@indecliente", abo.Idencliente);
            actualizar.Parameters.AddWithValue("@nombrecliente", abo.Nombrecliente);
            actualizar.Parameters.AddWithValue("@codigoproducto", abo.Codigoavender);
            actualizar.Parameters.AddWithValue("@producto", abo.Producto);
            actualizar.Parameters.AddWithValue("@cantidadavender", abo.Cantidadavender);
            actualizar.Parameters.AddWithValue("@total", abo.Total);

            actualizar.ExecuteNonQuery();
            
        }

        public DataTable mostrardatos()
        {
            
            //es un metodo para visualizar los datos de una base de datos
            conexion.conectar();

            DataTable dtc = new DataTable();

            string consulta = "SELECT indecliente,nombrecliente,codigoproducto,producto,cantidadavender,total from venta";

            SqlCommand cmd = new SqlCommand(consulta, conexion.conectar());

            SqlDataAdapter cargar = new SqlDataAdapter(cmd);

            cargar.Fill(dtc);
            return dtc;
            
        }
        //borro un dato de la base de datos 
        public void eleminarventa(ventas abo)
        {
            
            conexion.conectar();
            string eliminar = "DELETE FROM venta where idfactura=@idfatura";

            SqlCommand borrar = new SqlCommand(eliminar, conexion.conectar());

            borrar.Parameters.AddWithValue("@idfactura",abo.Numfactura);

            borrar.ExecuteNonQuery();
            Listaventas.Remove(abo);
            
        }
    }
}
