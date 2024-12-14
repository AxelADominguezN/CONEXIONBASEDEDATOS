using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CONEXIONBASEDEDATOS
{
    public class BDGENERAL
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection("Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = BD_GRANJA; Data Source = LAPTOP-90P9GN2J\\MSSQLSERVER01");
            conexion.Open();

            return conexion;
        }
    }
}
