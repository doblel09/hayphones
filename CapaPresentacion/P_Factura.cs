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
        public N_Factura facturar = new N_Factura(new D_Factura());
       
        public int numerofactura { get; set; }

        public bool verificarfac(int numfac)
        {
            return facturar.VerificarFactura(numfac);
        }
        public void ActualizarDetalle(int idfac)
        {
            dataGridView1.DataSource = facturar.MostrarDetalleFactura(idfac);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
        }

        public void ActualizarInventario()
        {
            inventarioGridView.DataSource = facturar.ObtenerInventario();
        }
        public bool guardarfactura;
        public void determinarfactura()
        {
            numerofactura = facturar.ObtenerFactura();
            numFacturaBox.Text = Convert.ToString(numerofactura);
            ActualizarDetalle(numerofactura);
            ActualizarInventario();

        }
        public void eliminarfac(int idfac)
        {
            facturar.EliminarFactura(idfac);
        }
        public void facturaguardada(int idfac)
        {
            facturar.FacturaGuardada(idfac);
        }
        private void P_Factura_Load(object sender, EventArgs e)
        {
            determinarfactura();
            fechaLabel1.Text = DateTime.Now.ToString("dd/MM/yyyy");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void addFP_Click(object sender, EventArgs e)
        {
            guardarfactura = false;
            facturar.CrearFactura(numerofactura, DatosUsuario.IdUsuario);
            int agregar = facturar.AgregarProducto(numerofactura, Convert.ToInt32(inventarioGridView.CurrentRow.Cells[0].Value), Convert.ToInt32(cantidadFP.Value));
            if (agregar > 0)
            {
                MessageBox.Show("Producto Agregado.");
                ActualizarDetalle(numerofactura);
                ActualizarInventario();
                totalPF.Text = Convert.ToString(facturar.TotalMaster(numerofactura))+"$";
            }
            else
            {
                MessageBox.Show("No hay suficiente stock disponible.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                int producto = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
                facturar.EliminarDetalle(numerofactura, producto, Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                MessageBox.Show("Registro Eliminado.");
                ActualizarDetalle(numerofactura);
                ActualizarInventario();
                totalPF.Text = Convert.ToString(facturar.TotalMaster(numerofactura)) + "$";
            }
            else
            {
                MessageBox.Show("No hay datos para eliminar.");
            }

        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                inventarioGridView.DataSource = facturar.Buscar(comboBox1.Text, textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public void EliminarFactura()
        {
            facturar.EliminarFactura(numerofactura);
            ActualizarInventario();
            ActualizarDetalle(numerofactura);
            MessageBox.Show("Factura eliminada");
        }

                        

                     
                        
                    

                
    

        private void imprimirPF_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea continuar?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                // código a ejecutar si el usuario hace clic en "Sí"
                guardarfactura = true;

            }
            else
            {
                guardarfactura = false;
            }

            if (guardarfactura == true)
            {
                string nombrecliente;
                string comment;
                if (string.IsNullOrEmpty(clienteFP.Text))
                {
                    nombrecliente = "N/A";
                }
                else
                {
                    nombrecliente = clienteFP.Text;
                }
                if (string.IsNullOrEmpty(commentPF.Text))
                {
                    comment = "N/A";
                }
                else
                {
                    comment = clienteFP.Text;
                }
                facturar.Guardar(numerofactura, nombrecliente, comment);


                MessageBox.Show("Factura almacenada.");
                determinarfactura();


            }
            else
            {
                guardarfactura = false;
            }


        }

        private void clearPF_Click(object sender, EventArgs e)
        {
            EliminarFactura();
        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            ActualizarInventario();
        }
    } }

