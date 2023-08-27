using CapaDatos;
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

namespace CapaPresentacion
{
    public partial class P_Inventario : UserControl
    {
        public P_Inventario()
        {
            InitializeComponent();
            ActualizarInventario();
        }

        D_Inventario inventario = new D_Inventario();

        private void ActualizarInventario()
        {
            dataGridView1.DataSource = inventario.ObtenerInventario();
        }
        private void Limpiar()
        {

            idProductoBox.Clear();
            descProductoBox.Clear();
            precioBox.Clear();
            IMEIbox.Clear();
            numericUpDown1.Value = 1;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            idProductoBox.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            descProductoBox.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            precioBox.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            IMEIbox.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            numericUpDown1.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
        }
        private void P_Inventario_Load(object sender, EventArgs e)
        {
            if (DatosUsuario.NivelAcceso != "admin")
            {
                button4.Visible = false;
                button5.Visible = false;
            }
            Limpiar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (descProductoBox.Text == "" || precioBox.Text == "")
            {
                MessageBox.Show("Faltan datos por completar.");
            } else {
            try
            {
                inventario.InsertarProducto(descProductoBox.Text, Convert.ToInt32(precioBox.Text), Convert.ToInt32(numericUpDown1.Value), IMEIbox.Text);
                MessageBox.Show("Producto Agregado.");
                ActualizarInventario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (descProductoBox.Text == "" || precioBox.Text == "")
            {
                MessageBox.Show("Faltan datos por completar.");
            }
            else
            {
                try
                {
                    inventario.EditarProducto(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), descProductoBox.Text, Convert.ToInt32(precioBox.Text), Convert.ToInt32(numericUpDown1.Value), IMEIbox.Text);
                    MessageBox.Show("Producto Modificado.");
                    ActualizarInventario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                inventario.EliminarProducto(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                MessageBox.Show("Producto Eliminado.");
                ActualizarInventario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    dataGridView1.DataSource = inventario.Buscar(comboBox1.Text, textBox1.Text);
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
            Limpiar();
            
        }
    }
}

