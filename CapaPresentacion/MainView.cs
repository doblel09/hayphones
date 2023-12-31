﻿using CapaDatos;
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
    public partial class MainView : Form
    {
        

        public MainView()
        {
            InitializeComponent();
            
        }
        public string username { get; set; }
        public string acclvl { get; set; }

        private void p_Factura1_Load(object sender, EventArgs e)
        {

        }
        P_Factura factura = new P_Factura();
        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
           if (factura.verificarfac(factura.numerofactura) == true)
            {

            }else if (factura.verificarfac(factura.numerofactura) == false)
            {
                DialogResult resultado = MessageBox.Show("Esta factura aun no ha sido guardada. Desea guardar esta factura??", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    factura.eliminarfac(factura.numerofactura);

                }
                else if (resultado == DialogResult.Yes)
                {
                    factura.facturaguardada(factura.numerofactura);

                }

            }
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            NombreUsuario.Text = DatosUsuario.NombreUsuario;
            if (DatosUsuario.NivelAcceso == "admin")
            {
                Niveldeacceso.Text = "Administrador";
            }
            else
            {
                Niveldeacceso.Text = "Cajero";
            }
            p_Factura1.Visible= true;
            p_Inventario1.Visible = false;
        }

        private void p_Factura1_Load_1(object sender, EventArgs e)
        {

        }

        private void p_Inventario1_Load(object sender, EventArgs e)
        {
            
        }

        private void ventaShow_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(48, 85, 215);
            p_Factura1.Visible = true;
            p_Inventario1.Visible = false;
        }

        private void inventarioShow_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ControlDark;
            p_Factura1.Visible = false;
            p_Inventario1.Visible = true;
        }
    }
    }

