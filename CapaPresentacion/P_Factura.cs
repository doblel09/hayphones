using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;


namespace CapaPresentacion
{
    public partial class P_Factura : UserControl
    {
        public P_Factura()
        {
            InitializeComponent();


        }
        private D_Factura facturar = new D_Factura();



    }
}
