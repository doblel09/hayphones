using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocios
{
    public class N_Factura
    {
        private FacturaDAO facturaDAO;

        public int iduser { get; set; }

        public N_Factura(FacturaDAO facturaDAO)
        {
            this.facturaDAO = facturaDAO;
        }

        public int ObtenerFactura()
        {
            return facturaDAO.DeterminarFactura();
        }
        public void CrearFactura(int idfac, int userid)
        {
            facturaDAO.crearFactura(idfac, userid);
        }
        public DataTable MostrarDetalleFactura(int idFac)
        {
            return facturaDAO.DetalleFactura(idFac);
        }
        public DataTable ObtenerInventario()
        {
            return facturaDAO.ObtenerInventario();
        }
        public int AgregarProducto(int idFac, int idProd, int cantidad)
        {
            return facturaDAO.AgregarProducto(idFac, idProd, cantidad);
        }
        public int EliminarDetalle(int idFac, int idProd, int idDetalle)
        {
            return facturaDAO.EliminarDetalle(idFac, idProd, idDetalle);
        }

        public void InventarioAgregar(string desc, int precio, int stock, string imei)
        {
            facturaDAO.InsertarProducto(desc, precio, stock, imei);
        }
        public void InventarioModificar(int id, string desc, int precio, int stock, string imei)
        {
            facturaDAO.EditarProducto(id, desc, precio, stock, imei);
        }
        public void InventarioEliminar(int id)
        {
            facturaDAO.EliminarProducto(id);
        }

        public DataTable Buscar(string criterio, string campo)
        {
            return facturaDAO.BuscarProducto(criterio, campo);
        }

        public void Guardar(int idfac, string cliente, string comment)
        {
            facturaDAO.GuardarFactura(idfac, cliente, comment);
                }
        public void EliminarFactura(int idfac)
        {
            facturaDAO.EliminarFactura(idfac);
        }

        public bool VerificarFactura(int idFac)
        {
            return facturaDAO.VerificarFacturaGuardada(idFac);
        }

        public void FacturaGuardada(int idFac)
        {
            facturaDAO.ActualizarFacturaGuardada(idFac);
        }

        public int TotalMaster(int idFac)
        {
            return facturaDAO.TotalMaster(idFac);
        }
    }

}
