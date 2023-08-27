using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class D_Inventario
    {
        private string connectionString = "Server=LAPTOP-RE0VFDER\\SQLEXPRESS;Database=HayPhones;Integrated Security=True;";

        public SqlConnection Conectarbd = new SqlConnection();

        public D_Inventario()
        {
            Conectarbd.ConnectionString = connectionString;
        }

        public DataTable ObtenerInventario()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_productoinventario", Conectarbd);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                Conectarbd.Open();
                da.Fill(dt);
                Conectarbd.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar inventario.", ex);
            }
        }

            public void InsertarProducto(string desc, int precio, int stock, string imei)
        {
            SqlCommand cmd = new SqlCommand("sp_insertarProducto", Conectarbd);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@descripcion", desc);
            cmd.Parameters.AddWithValue("@precio", precio);
            cmd.Parameters.AddWithValue("@stock", stock);
            cmd.Parameters.AddWithValue("@imei", stock);

            Conectarbd.Open();
            cmd.ExecuteNonQuery();
            Conectarbd.Close();
        }

        public void EliminarProducto(int id)
        {
            SqlCommand cmd = new SqlCommand("sp_eliminarProducto", Conectarbd);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);

            Conectarbd.Open();
            cmd.ExecuteNonQuery();
            Conectarbd.Close();
        }
        public void EditarProducto(int id, string desc, int precio, int stock, string imei)
        {
            SqlCommand cmd = new SqlCommand("sp_actualizarProducto", Conectarbd);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@descripcion", desc);
            cmd.Parameters.AddWithValue("@precio", precio);
            cmd.Parameters.AddWithValue("@stock", stock);
            cmd.Parameters.AddWithValue("@imei", imei);

            Conectarbd.Open();
            cmd.ExecuteNonQuery();
            Conectarbd.Close();
        }

        public DataTable Buscar(string criterio, string campo)
        {
            SqlCommand cmd = new SqlCommand("sp_buscarProducto", Conectarbd);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@criterio", criterio);
            cmd.Parameters.AddWithValue("@campo", campo);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            Conectarbd.Open();
            da.Fill(dt);
            Conectarbd.Close();
            return dt;
        }

    }
}
