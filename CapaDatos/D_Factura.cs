using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Security.Cryptography;
using CapaNegocios;

namespace CapaDatos
{
    public class D_Factura : FacturaDAO
    {
        private string connectionString = "Server=LAPTOP-RE0VFDER\\SQLEXPRESS;Database=HayPhones;Integrated Security=True;";

        private SqlConnection Conectarbd = new SqlConnection();
        private SqlTransaction transaction;

        public void IniciarTransaccion()
        {
            if (Conectarbd.State != ConnectionState.Open)
                Conectarbd.Open();

            transaction = Conectarbd.BeginTransaction();
        }

        public void CommitTransaccion()
        {
            if (transaction != null)
            {
                transaction.Commit();
                transaction = null;
            }

            if (Conectarbd.State == ConnectionState.Open)
                Conectarbd.Close();
        }

        public void RollbackTransaccion()
        {
            if (transaction != null)
            {
                transaction.Rollback();
                transaction = null;
            }

            if (Conectarbd.State == ConnectionState.Open)
                Conectarbd.Close();
        }

        public D_Factura()
        {
            Conectarbd.ConnectionString = connectionString;
        }
        //Determinar factura
        public int DeterminarFactura()
        {
            int factura = 0;
            SqlCommand cmd = new SqlCommand("sp_determinarfactura", Conectarbd);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@factura", SqlDbType.Int).Direction = ParameterDirection.Output;
            Conectarbd.Open();
            cmd.ExecuteNonQuery();
            factura = Convert.ToInt32(cmd.Parameters["@factura"].Value);
            Conectarbd.Close();
            return factura;
        }
        //Crea la factura si no ha sido creada, si ya existe sigue trabajando en la misma
        public void crearFactura(int idFac, int userId)
        {
            Conectarbd.Open();
            SqlCommand cmd = new SqlCommand("sp_crearfactura", Conectarbd);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idFac", idFac);
            cmd.Parameters.AddWithValue("@userID", userId);

            SqlParameter outputParam = new SqlParameter("@result", SqlDbType.Int);
            outputParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outputParam);

            cmd.ExecuteNonQuery();
            Conectarbd.Close();

            if (Convert.ToInt32(outputParam.Value) == 0)
            {
                throw new Exception("Error al crear la factura.");
            }
        }
        //Muestra el detalle de la factura actual
        public DataTable DetalleFactura(int idFac)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_DetalleFactura", Conectarbd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idFac", idFac);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                Conectarbd.Open();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar DetalleFactura: " + ex.Message);
            }
            finally
            {
                Conectarbd.Close();
            }
            return dt;
        }
        //Obtener inventario
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
        public int AgregarProducto(int idFac, int idProd, int cantidad)
        {
            SqlCommand cmd = new SqlCommand("sp_agregarProducto", Conectarbd);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idFac", idFac);
            cmd.Parameters.AddWithValue("@idProd", idProd);
            cmd.Parameters.AddWithValue("@cantidad", cantidad);

            SqlParameter outputParam = new SqlParameter("@result", SqlDbType.Int);
            outputParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outputParam);

            Conectarbd.Open();
            cmd.ExecuteNonQuery();
            Conectarbd.Close();

            return Convert.ToInt32(outputParam.Value);
        }
        public int EliminarDetalle(int idFac, int idProd, int idDetalle)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_eliminarDetalle", Conectarbd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idFac", idFac);
                cmd.Parameters.AddWithValue("@idProd", idProd);
                cmd.Parameters.AddWithValue("@idDetalle", idDetalle);

                SqlParameter outputParam = new SqlParameter("@result", SqlDbType.Int);
                outputParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outputParam);

                Conectarbd.Open();
                cmd.ExecuteNonQuery();
                Conectarbd.Close();

                return Convert.ToInt32(outputParam.Value);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar detalle de factura: " + ex.Message);
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

        public DataTable BuscarProducto(string criterio, string campo)
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

        public void GuardarFactura(int idfac, string cliente, string comment)
        {
            SqlCommand cmd = new SqlCommand("sp_guardarFactura", Conectarbd);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idFac", idfac);
            cmd.Parameters.AddWithValue("@Cliente", cliente);
            cmd.Parameters.AddWithValue("@Comment", comment);

            Conectarbd.Open();
            cmd.ExecuteNonQuery();
            Conectarbd.Close();
        }


        public void EliminarFactura(int idfac)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_eliminarFactura", Conectarbd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idFac", idfac);
                cmd.Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.Output;

                Conectarbd.Open();
                cmd.ExecuteNonQuery();
                int resultado = Convert.ToInt32(cmd.Parameters["@result"].Value);
                Conectarbd.Close();

                if (resultado == 0) { 
                    throw new Exception("La condición no se cumple"); }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar factura: " + ex.Message);
            }
        }

        public bool VerificarFacturaGuardada(int idFac)
        {
            SqlCommand cmd = new SqlCommand("SELECT Guardar FROM Tbl_MasterFac WHERE ID_Master = @idFac", Conectarbd);
            cmd.Parameters.AddWithValue("@idFac", idFac);
            Conectarbd.Open();
            int guardar = Convert.ToInt32(cmd.ExecuteScalar());
            Conectarbd.Close();
            return guardar == 1;
        }

        public void ActualizarFacturaGuardada(int idFac)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Tbl_MasterFac SET Guardar = 1 WHERE ID_Master = @idFac", Conectarbd);
            cmd.Parameters.AddWithValue("@idFac", idFac);
            Conectarbd.Open();
            cmd.ExecuteNonQuery();
            Conectarbd.Close();
        }

        public int TotalMaster(int idFac)
        {
            SqlCommand cmd = new SqlCommand("SELECT Total FROM Tbl_MasterFac WHERE ID_Master = @idFac", Conectarbd);
            cmd.Parameters.AddWithValue("@idFac", idFac);
            Conectarbd.Open();
            int total = Convert.ToInt32(cmd.ExecuteScalar());
            Conectarbd.Close();
            return total;
        }




    }
}
