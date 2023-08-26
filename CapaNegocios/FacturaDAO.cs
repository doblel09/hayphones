using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public interface FacturaDAO
    {
        int DeterminarFactura();
        void crearFactura(int idFac, int userId);
        DataTable DetalleFactura(int idFac);
        DataTable ObtenerInventario();
        int AgregarProducto(int idFac, int idProd, int cantidad);
        int EliminarDetalle(int idFac, int idProd, int idDetalle);
        void InsertarProducto(string desc, int precio, int stock, string imei);
        void EliminarProducto(int id);
        void EditarProducto(int id, string desc, int precio, int stock, string imei);
        DataTable BuscarProducto(string criterio, string campo);
        void GuardarFactura(int idfac, string cliente, string comment);
        void EliminarFactura(int idfac);
        bool VerificarFacturaGuardada(int idFac);

        void ActualizarFacturaGuardada(int idFac);

        int TotalMaster(int idFac);

    }
}
