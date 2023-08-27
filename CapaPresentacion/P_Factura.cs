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

        public bool guardar;

        private D_Factura facturar = new D_Factura();
        public int numeroFactura;
        private void P_Factura_Load(object sender, EventArgs e)
        {
            facturar.IniciarTransaccion();
            //Obtiene numero de factura y lo asigna al front end
            numeroFactura = facturar.DeterminarFactura();
            numFacturaBox.Text = Convert.ToString(numeroFactura);
            //Obtiene los datos del inventario y los muestra
            ActualizarInventario();
            fechaLabel1.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        public void ActualizarDetalle(int num)
        {
            //Obtiene los datos del Detalle y los muestra
            dataGridView1.DataSource = facturar.DetalleFactura(num);
        }
        public void ActualizarInventario()
        {
            //Obtiene los datos del inventario y los muestra
            inventarioGridView.DataSource = facturar.ObtenerInventario();
        }

        private void addFP_Click(object sender, EventArgs e)
        {
            guardar = false;
            facturar.crearFactura(numeroFactura, 1);
            
            int agregar = facturar.AgregarProducto(numeroFactura, Convert.ToInt32(inventarioGridView.CurrentRow.Cells[0].Value), Convert.ToInt32(cantidadFP.Value));
            if (agregar > 0)
            {
                MessageBox.Show("Producto Agregado.");
                ActualizarDetalle(numeroFactura);
                ActualizarInventario();
            }
            else
            {
                MessageBox.Show("No hay suficiente stock disponible.");
            }
        }


        private void buscarBtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Faltan criterios para su búsqueda.");
            }
            else
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
        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            ActualizarInventario();
        }

        private void imprimirPF_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Esta factura aun no ha sido guardada. Desea limpiar esta factura??", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                //No pasa nada

            }
            else if (resultado == DialogResult.Yes)
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
                facturar.GuardarFactura(numeroFactura, nombrecliente, comment);
                dataGridView1.DataSource = null;
                clienteFP.Clear();
                commentPF.Clear();
                facturar.IniciarTransaccion();
                numeroFactura = facturar.DeterminarFactura();
                numFacturaBox.Text = Convert.ToString(numeroFactura);
                ActualizarInventario();
            }
            
            
        }
        public void LimpiarFactura()
        {
            if (dataGridView1.RowCount == 0)
            {
                guardar = true;
            }

            if (guardar == false)
            {
                DialogResult resultado = MessageBox.Show("Esta factura aun no ha sido guardada. Desea limpiar esta factura??", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    //No pasa nada

                }
                else if (resultado == DialogResult.Yes)
                {
                    facturar.RollbackTransaccion();
                    dataGridView1.DataSource = null;
                    facturar.IniciarTransaccion();
                    ActualizarInventario();
                }

            }
        }
        public void CerrarPrograma()
        {
            if (dataGridView1.RowCount == 0)
            {
                guardar = true;
            }

            if (guardar == false)
            {
                DialogResult resultado = MessageBox.Show("Esta factura aun no ha sido guardada. Desea guardar esta factura?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    facturar.RollbackTransaccion();

                }
                else if (resultado == DialogResult.Yes)
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
                    facturar.GuardarFactura(numeroFactura, nombrecliente, comment);
                }
            }
            else {
                facturar.RollbackTransaccion();
            }
        }
        private void clearPF_Click(object sender, EventArgs e)
        {

            LimpiarFactura();
            MessageBox.Show("Factura eliminada");
        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                int producto = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
                facturar.EliminarDetalle(numeroFactura, producto, Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                MessageBox.Show("Registro Eliminado.");
                ActualizarDetalle(numeroFactura);
                ActualizarInventario();
                totalPF.Text = Convert.ToString(facturar.TotalMaster(numeroFactura)) + "$";
            }
            else
            {
                MessageBox.Show("No hay datos para eliminar.");

            }


        }
    }
}
