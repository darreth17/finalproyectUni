using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace datos
{
    public class conexion
    {
        // hago una conexion a la base de datos
        public static SqlConnection conectar()
        {

            SqlConnection con = new SqlConnection("Data Source = DESKTOP-3PPQCSM; Initial Catalog = proyectofinal; Integrated Security = True");

            con.Open();

            return con;

        }
    }
}
