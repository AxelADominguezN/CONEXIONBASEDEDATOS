using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CONEXIONBASEDEDATOS
{
    public class VACASDAL
    {
        public static int AgregarVaca(VacasID VACA)
        {
            int retorna = 0;

            using (SqlConnection conexion = BDGENERAL.ObtenerConexion())
            {
                string query = "insert into VacasID (Nombre,Raza,Estado) values('"+VACA.Nombre+"','"+VACA.Raza+"','"+VACA.Estado+"')";
                SqlCommand comando = new SqlCommand(query, conexion);

                retorna = comando.ExecuteNonQuery();
            }
            return retorna;
        }

        public static List<VacasID> PresentarRegistro()
        {
            List<VacasID> lista = new List<VacasID>();

            using(SqlConnection conexion = BDGENERAL.ObtenerConexion())
            {
                string query = "Select *from VacasID";
                SqlCommand comando = new SqlCommand(query,conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while(reader.Read())
                {
                    VacasID vaca = new VacasID();
                    vaca.IDVACA = reader.GetInt32(0);
                    vaca.Nombre = reader.GetString(1);
                    vaca.Raza = reader.GetString(2);
                    vaca.Estado = reader.GetString(3);
                    lista.Add(vaca);
                    
                }
                conexion.Close();
                return lista;
            }
        }
        public static int modificarvaca(VacasID vaca)
        {
            int result = 0;
            using (SqlConnection conexion = BDGENERAL.ObtenerConexion())
            {
                string query = "update VacasID set Nombre='"+vaca.Nombre+"', Raza='"+vaca.Raza+"', Estado='"+vaca.Estado+"' where IDVACA='"+vaca.IDVACA+"'";
                SqlCommand comando = new SqlCommand(query, conexion);
                
                result= comando.ExecuteNonQuery();
                conexion.Close();
            }
            return result;
        }
        public static int EliminarVaca(int id)
        {
            int retorna = 0;

            using (SqlConnection conexion = BDGENERAL.ObtenerConexion())
            {
                string query = "delete from VacasID where IDVACA='" + id + "'";
                SqlCommand comando = new SqlCommand(query, conexion);
                
                retorna = comando.ExecuteNonQuery();
            }
            return retorna;
        }
    }

}
