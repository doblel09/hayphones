using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaNegocios;

namespace CapaDatos
{
    public static class DatosUsuario
    {
        public static int IdUsuario { get; set; }
        public static string NombreUsuario { get; set; }
        public static string NivelAcceso { get; set; }
    }
    public class D_Login : LoginDAO
    {

        private string connectionString = "Server=LAPTOP-RE0VFDER\\SQLEXPRESS;Database=HayPhones;Integrated Security=True;";

        private SqlConnection Conectarbd = new SqlConnection();
        public D_Login(){

        Conectarbd.ConnectionString = connectionString;
        }

        public int Login(string username, string password)
        {
            int devolver=0;
            SqlCommand cmd = new SqlCommand("sp_login", Conectarbd);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@pass", password);

            SqlParameter result = new SqlParameter("@result", SqlDbType.Int);
            result.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(result);

            SqlParameter iduser = new SqlParameter("@id", SqlDbType.Int);
            iduser.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(iduser);

            SqlParameter nombre = new SqlParameter("@nombre", SqlDbType.NVarChar, 50);
            nombre.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(nombre);

            SqlParameter acclevel = new SqlParameter("@acclevel", SqlDbType.Char, 5);
            acclevel.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(acclevel);

            Conectarbd.Open();
            cmd.ExecuteNonQuery();
            Conectarbd.Close();

            
            if (Convert.ToInt32(result.Value) == 0)
            {
                devolver = 0;
            }
            else if (Convert.ToInt32(result.Value) == 1)
            {

                DatosUsuario.IdUsuario = (int)iduser.Value;
                DatosUsuario.NombreUsuario = (string)nombre.Value;
                DatosUsuario.NivelAcceso = (string)acclevel.Value;
                devolver = 1;
            }
            return devolver;


        }
    }
}
