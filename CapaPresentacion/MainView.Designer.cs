using System.Windows.Forms;

namespace CapaPresentacion
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ventaShow = new System.Windows.Forms.Button();
            this.inventarioShow = new System.Windows.Forms.Button();
            this.Niveldeacceso = new System.Windows.Forms.Label();
            this.NombreUsuario = new System.Windows.Forms.Label();
            this.p_Inventario1 = new CapaPresentacion.P_Inventario();
            this.p_Factura1 = new CapaPresentacion.P_Factura();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.menu.Controls.Add(this.pictureBox1);
            this.menu.Controls.Add(this.ventaShow);
            this.menu.Controls.Add(this.inventarioShow);
            this.menu.Location = new System.Drawing.Point(1, 89);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(291, 500);
            this.menu.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.WhatsApp_Image_2023_02_22_at_10_47_53_PM;
            this.pictureBox1.Location = new System.Drawing.Point(26, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ventaShow
            // 
            this.ventaShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(85)))), ((int)(((byte)(215)))));
            this.ventaShow.BackgroundImage = global::CapaPresentacion.Properties.Resources.boton_venta;
            this.ventaShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ventaShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ventaShow.Location = new System.Drawing.Point(26, 42);
            this.ventaShow.Name = "ventaShow";
            this.ventaShow.Size = new System.Drawing.Size(228, 55);
            this.ventaShow.TabIndex = 5;
            this.ventaShow.UseVisualStyleBackColor = false;
            this.ventaShow.Click += new System.EventHandler(this.ventaShow_Click);
            // 
            // inventarioShow
            // 
            this.inventarioShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.inventarioShow.BackgroundImage = global::CapaPresentacion.Properties.Resources.Screenshot_2023_02_22_202109;
            this.inventarioShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventarioShow.Location = new System.Drawing.Point(26, 103);
            this.inventarioShow.Name = "inventarioShow";
            this.inventarioShow.Size = new System.Drawing.Size(228, 55);
            this.inventarioShow.TabIndex = 6;
            this.inventarioShow.UseVisualStyleBackColor = false;
            this.inventarioShow.Click += new System.EventHandler(this.inventarioShow_Click);
            // 
            // Niveldeacceso
            // 
            this.Niveldeacceso.AutoSize = true;
            this.Niveldeacceso.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Niveldeacceso.ForeColor = System.Drawing.Color.White;
            this.Niveldeacceso.Location = new System.Drawing.Point(22, 51);
            this.Niveldeacceso.Name = "Niveldeacceso";
            this.Niveldeacceso.Size = new System.Drawing.Size(142, 25);
            this.Niveldeacceso.TabIndex = 8;
            this.Niveldeacceso.Text = "Administrador";
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.AutoSize = true;
            this.NombreUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreUsuario.ForeColor = System.Drawing.Color.White;
            this.NombreUsuario.Location = new System.Drawing.Point(20, 9);
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.Size = new System.Drawing.Size(258, 42);
            this.NombreUsuario.TabIndex = 7;
            this.NombreUsuario.Text = "Luis Florentino";
            // 
            // p_Inventario1
            // 
            this.p_Inventario1.BackColor = System.Drawing.Color.Black;
            this.p_Inventario1.Location = new System.Drawing.Point(298, 89);
            this.p_Inventario1.Name = "p_Inventario1";
            this.p_Inventario1.Size = new System.Drawing.Size(1102, 538);
            this.p_Inventario1.TabIndex = 4;
            this.p_Inventario1.Load += new System.EventHandler(this.p_Inventario1_Load);
            // 
            // p_Factura1
            // 
            this.p_Factura1.BackColor = System.Drawing.Color.Black;
            this.p_Factura1.Location = new System.Drawing.Point(298, 89);
            this.p_Factura1.Name = "p_Factura1";
            this.p_Factura1.Size = new System.Drawing.Size(1075, 500);
            this.p_Factura1.TabIndex = 2;
            this.p_Factura1.Load += new System.EventHandler(this.p_Factura1_Load_1);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(85)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(1374, 588);
            this.Controls.Add(this.Niveldeacceso);
            this.Controls.Add(this.NombreUsuario);
            this.Controls.Add(this.p_Inventario1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.p_Factura1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainView";
            this.Text = "HayPhones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.Load += new System.EventHandler(this.MainView_Load);
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private P_Factura p_Factura1;
        private System.Windows.Forms.Panel menu;
        private P_Inventario p_Inventario1;
        private Button ventaShow;
        private Button inventarioShow;
        private Label Niveldeacceso;
        private Label NombreUsuario;
        private PictureBox pictureBox1;
    }
}

