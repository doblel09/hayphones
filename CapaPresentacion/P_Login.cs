using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class P_Login : Form
    {
        public P_Login()
        {
            InitializeComponent();
        }

        private N_Login log = new N_Login(new D_Login());

        private void button1_Click(object sender, EventArgs e)
        {
            int login = log.Login(usuarioBox.Text,passwordBox.Text);
            if (login == 0)
            {
                MessageBox.Show("Datos Incorrectos.");
            }else if (login == 1)
            {
                MainView mainview = new MainView();
                //mainview.acclvl = ;
                //mainview.username = ;
                //P_Factura factura = new P_Factura();
                //factura.iduser = ;
                this.Hide();
                
                mainview.ShowDialog();
                this.Close();
            }
        }

        private void P_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
