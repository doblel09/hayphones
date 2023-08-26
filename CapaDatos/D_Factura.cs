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
    public class D_Factura
    {
        private string connectionString = "Server=LAPTOP-RE0VFDER\\SQLEXPRESS;Database=HayPhones;Integrated Security=True;";

        private SqlConnection Conectarbd = new SqlConnection();
        private SqlTransaction transaction;
        public int Guardar = 0;

        public D_Factura() { 
        Conectarbd.ConnectionString = connectionString;
        }

        //public void IniciarTransaccion()
        //{
        //    if (Conectarbd.State != ConnectionState.Open) {
        //        Conectarbd.Open();
        //    }

        //    transaction = Conectarbd.BeginTransaction();
        //}

        //public void CommitTransaccion()
        //{
        //    if (transaction != null)
        //    {
        //        transaction.Commit();
        //        transaction = null;
        //    }

        //    if (Conectarbd.State == ConnectionState.Open)
        //        Conectarbd.Close();
        //}

        //public void RollbackTransaccion()
        //{
        //    if (transaction != null)
        //    {
        //        transaction.Rollback();
        //        transaction = null;
        //    }

        //    if (Conectarbd.State == ConnectionState.Open)
        //        Conectarbd.Close();
        //}

        //public void CerrarConexion()
        //{
        //    if (Conectarbd.State == ConnectionState.Open)
        //    {
        //        Conectarbd.Close();
        //    }
        //}

        ////Determinar factura
        //public int DeterminarFactura()
        //{
        //    try {
            
        //    int factura = 0;
        //    SqlCommand cmd = new SqlCommand("sp_determinarfactura", Conectarbd, transaction);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Add("@factura", SqlDbType.Int).Direction = ParameterDirection.Output;
            
        //    cmd.ExecuteNonQuery();
        //    factura = Convert.ToInt32(cmd.Parameters["@factura"].Value);
            
        //    return factura;
            
        //    }
        //    catch (Exception ex)
        //    {
        //        RollbackTransaccion();
        //        throw new Exception("Error al crear la factura.");
        //    }
        //}
        ////Crea la factura si no ha sido creada, si ya existe sigue trabajando en la misma
        //public void crearFactura(int idFac, int userId)
        //{
        //    try {
                
        //        SqlCommand cmd = new SqlCommand("sp_crearfactura", Conectarbd, transaction);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@idFac", idFac);
        //        cmd.Parameters.AddWithValue("@userID", userId);

        //        SqlParameter outputParam = new SqlParameter("@result", SqlDbType.Int);
        //        outputParam.Direction = ParameterDirection.Output;
        //        cmd.Parameters.Add(outputParam);

        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        RollbackTransaccion();
        //    }
        //}
        ////Muestra el detalle de la factura actual
        //public DataTable DetalleFactura(int idFac)
        //{
        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand("sp_DetalleFactura", Conectarbd, transaction);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@idFac", idFac);
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
                
        //        da.Fill(dt);
        //    }
        //    catch (Exception ex)
        //    {
        //        RollbackTransaccion();
        //        throw new Exception("Error al mostrar DetalleFactura: " + ex.Message);

        //    }
        //    return dt;
        //}
        ////Obtener inventario
        //public DataTable ObtenerInventario()
        //{
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand("sp_productoinventario", Conectarbd, transaction);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        RollbackTransaccion();
        //        throw new Exception("Error al mostrar inventario.", ex);
        //    }
        //}
        //public int AgregarProducto(int idFac, int idProd, int cantidad)
        //{
        //    try { 
        //    SqlCommand cmd = new SqlCommand("sp_agregarProducto", Conectarbd, transaction);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@idFac", idFac);
        //    cmd.Parameters.AddWithValue("@idProd", idProd);
        //    cmd.Parameters.AddWithValue("@cantidad", cantidad);

        //    SqlParameter outputParam = new SqlParameter("@result", SqlDbType.Int);
        //    outputParam.Direction = ParameterDirection.Output;
        //    cmd.Parameters.Add(outputParam);

        //    cmd.ExecuteNonQuery();

        //    return Convert.ToInt32(outputParam.Value);
        //    }
        //    catch (Exception ex)
        //    {
        //        RollbackTransaccion();
        //        throw new Exception("Error al agregar producto a la factura.", ex);
        //    }

        //}
        //public int EliminarDetalle(int idFac, int idProd, int idDetalle)
        //{
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand("sp_eliminarDetalle", Conectarbd, transaction);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@idFac", idFac);
        //        cmd.Parameters.AddWithValue("@idProd", idProd);
        //        cmd.Parameters.AddWithValue("@idDetalle", idDetalle);

        //        SqlParameter outputParam = new SqlParameter("@result", SqlDbType.Int);
        //        outputParam.Direction = ParameterDirection.Output;
        //        cmd.Parameters.Add(outputParam);

                
        //        cmd.ExecuteNonQuery();

        //        return Convert.ToInt32(outputParam.Value);
        //    }
        //    catch (Exception ex)
        //    {
        //        RollbackTransaccion();
        //        throw new Exception("Error al eliminar detalle de factura: " + ex.Message);
                
        //    }
        //}
        
        //public void GuardarFactura(int idfac, string cliente, string comment)
        //{
        //    Guardar = 1;
        //    if (Guardar == 1)
        //    {
        //        SqlCommand cmd = new SqlCommand("sp_guardarFactura", Conectarbd, transaction);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@idFac", idfac);
        //        cmd.Parameters.AddWithValue("@Cliente", cliente);
        //        cmd.Parameters.AddWithValue("@Comment", comment);
        //        cmd.ExecuteNonQuery();

        //        CommitTransaccion();
        //    }
        //    Guardar = 0;
        //}


        //public void EliminarFactura()
        //{
        //    try
        //    {
        //        RollbackTransaccion();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Error al eliminar factura: " + ex.Message);
        //    }
        //}





    }
}
