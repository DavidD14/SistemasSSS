using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DBCongreso
{
    class Clasegeneral
    {
        public static string cadena = "Data Source=SQL5023.SmarterASP.NET;Initial Catalog=DB_A28C2C_CongresoPrototipo;User ID=DB_A28C2C_CongresoPrototipo_admin;Password=progra2017";

        public static SqlConnection conexion = new SqlConnection(Clasegeneral.cadena);

        public static DataTable consultax(string consulta)
        {
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexion);
            DataTable ta = new DataTable();
            da.Fill(ta);
            return ta;
        }
    }
}