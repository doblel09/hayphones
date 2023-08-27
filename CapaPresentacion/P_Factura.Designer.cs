using System;

namespace CapaPresentacion
{
    partial class P_Factura
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fechaLabel1 = new System.Windows.Forms.Label();
            this.fechaLabel = new System.Windows.Forms.Label();
            this.clearPF = new System.Windows.Forms.Button();
            this.imprimirPF = new System.Windows.Forms.Button();
            this.commentPF = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.totalPF = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.limpiarBtn = new System.Windows.Forms.Button();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numFacturaBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.searchFP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cantidadFP = new System.Windows.Forms.NumericUpDown();
            this.addFP = new System.Windows.Forms.Button();
            this.inventarioGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCedula = new System.Windows.Forms.Label();
            this.clienteFP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadFP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(904, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 42);
            this.button3.TabIndex = 152;
            this.button3.Text = "ELIMINAR PRODUCTO";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(609, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(443, 221);
            this.dataGridView1.TabIndex = 151;
            // 
            // fechaLabel1
            // 
            this.fechaLabel1.AutoSize = true;
            this.fechaLabel1.ForeColor = System.Drawing.Color.White;
            this.fechaLabel1.Location = new System.Drawing.Point(265, 470);
            this.fechaLabel1.Name = "fechaLabel1";
            this.fechaLabel1.Size = new System.Drawing.Size(69, 13);
            this.fechaLabel1.TabIndex = 150;
            this.fechaLabel1.Text = "dd/mm/aaaa";
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.ForeColor = System.Drawing.Color.White;
            this.fechaLabel.Location = new System.Drawing.Point(225, 470);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(43, 13);
            this.fechaLabel.TabIndex = 149;
            this.fechaLabel.Text = "Fecha: ";
            // 
            // clearPF
            // 
            this.clearPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.clearPF.FlatAppearance.BorderSize = 0;
            this.clearPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearPF.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearPF.ForeColor = System.Drawing.Color.White;
            this.clearPF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clearPF.Location = new System.Drawing.Point(839, 404);
            this.clearPF.Name = "clearPF";
            this.clearPF.Size = new System.Drawing.Size(213, 64);
            this.clearPF.TabIndex = 143;
            this.clearPF.Text = "Limpiar";
            this.clearPF.UseVisualStyleBackColor = false;
            this.clearPF.Click += new System.EventHandler(this.clearPF_Click);
            // 
            // imprimirPF
            // 
            this.imprimirPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.imprimirPF.FlatAppearance.BorderSize = 0;
            this.imprimirPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imprimirPF.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imprimirPF.ForeColor = System.Drawing.Color.White;
            this.imprimirPF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.imprimirPF.Location = new System.Drawing.Point(609, 404);
            this.imprimirPF.Name = "imprimirPF";
            this.imprimirPF.Size = new System.Drawing.Size(213, 64);
            this.imprimirPF.TabIndex = 142;
            this.imprimirPF.Text = "Facturar e Imprimir";
            this.imprimirPF.UseVisualStyleBackColor = false;
            this.imprimirPF.Click += new System.EventHandler(this.imprimirPF_Click);
            // 
            // commentPF
            // 
            this.commentPF.Location = new System.Drawing.Point(608, 308);
            this.commentPF.MaxLength = 300;
            this.commentPF.Multiline = true;
            this.commentPF.Name = "commentPF";
            this.commentPF.Size = new System.Drawing.Size(266, 70);
            this.commentPF.TabIndex = 141;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.label28.Location = new System.Drawing.Point(604, 279);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(114, 25);
            this.label28.TabIndex = 148;
            this.label28.Text = "Comentario";
            // 
            // totalPF
            // 
            this.totalPF.AutoSize = true;
            this.totalPF.ForeColor = System.Drawing.Color.Red;
            this.totalPF.Location = new System.Drawing.Point(992, 370);
            this.totalPF.Name = "totalPF";
            this.totalPF.Size = new System.Drawing.Size(19, 13);
            this.totalPF.TabIndex = 147;
            this.totalPF.Text = "0$";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.label21.Location = new System.Drawing.Point(917, 368);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 13);
            this.label21.TabIndex = 146;
            this.label21.Text = "Total a pagar:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(603, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 26);
            this.label10.TabIndex = 145;
            this.label10.Text = "Revision";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.limpiarBtn);
            this.groupBox1.Controls.Add(this.buscarBtn);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.numFacturaBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.searchFP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cantidadFP);
            this.groupBox1.Controls.Add(this.addFP);
            this.groupBox1.Controls.Add(this.inventarioGridView);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelCedula);
            this.groupBox1.Controls.Add(this.clienteFP);
            this.groupBox1.Location = new System.Drawing.Point(16, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 450);
            this.groupBox1.TabIndex = 144;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.Location = new System.Drawing.Point(384, 140);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(75, 23);
            this.limpiarBtn.TabIndex = 120;
            this.limpiarBtn.Text = "Limpiar";
            this.limpiarBtn.UseVisualStyleBackColor = true;
            this.limpiarBtn.Click += new System.EventHandler(this.limpiarBtn_Click);
            // 
            // buscarBtn
            // 
            this.buscarBtn.Location = new System.Drawing.Point(302, 140);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(75, 23);
            this.buscarBtn.TabIndex = 119;
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = true;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Codigo",
            "Descripcion",
            "IMEI"});
            this.comboBox1.Location = new System.Drawing.Point(440, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(98, 21);
            this.comboBox1.TabIndex = 118;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(302, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 117;
            // 
            // numFacturaBox
            // 
            this.numFacturaBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.numFacturaBox.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.numFacturaBox.Location = new System.Drawing.Point(458, 4);
            this.numFacturaBox.Name = "numFacturaBox";
            this.numFacturaBox.ReadOnly = true;
            this.numFacturaBox.Size = new System.Drawing.Size(100, 20);
            this.numFacturaBox.TabIndex = 116;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(435, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 26);
            this.label9.TabIndex = 115;
            this.label9.Text = "#";
            // 
            // searchFP
            // 
            this.searchFP.BackColor = System.Drawing.Color.Transparent;
            this.searchFP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchFP.Location = new System.Drawing.Point(287, 136);
            this.searchFP.Name = "searchFP";
            this.searchFP.Size = new System.Drawing.Size(51, 40);
            this.searchFP.TabIndex = 106;
            this.searchFP.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(148, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 105;
            this.label1.Text = "Cantidad";
            // 
            // cantidadFP
            // 
            this.cantidadFP.Location = new System.Drawing.Point(143, 124);
            this.cantidadFP.Name = "cantidadFP";
            this.cantidadFP.Size = new System.Drawing.Size(54, 20);
            this.cantidadFP.TabIndex = 5;
            this.cantidadFP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addFP
            // 
            this.addFP.BackColor = System.Drawing.Color.DimGray;
            this.addFP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFP.Location = new System.Drawing.Point(17, 120);
            this.addFP.Name = "addFP";
            this.addFP.Size = new System.Drawing.Size(116, 43);
            this.addFP.TabIndex = 4;
            this.addFP.Text = "Agregar Producto";
            this.addFP.UseVisualStyleBackColor = false;
            this.addFP.Click += new System.EventHandler(this.addFP_Click);
            // 
            // inventarioGridView
            // 
            this.inventarioGridView.AllowUserToAddRows = false;
            this.inventarioGridView.AllowUserToDeleteRows = false;
            this.inventarioGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventarioGridView.Location = new System.Drawing.Point(6, 183);
            this.inventarioGridView.Name = "inventarioGridView";
            this.inventarioGridView.ReadOnly = true;
            this.inventarioGridView.Size = new System.Drawing.Size(559, 261);
            this.inventarioGridView.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(297, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 26);
            this.label4.TabIndex = 70;
            this.label4.Text = "Buscar Productos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(6, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 26);
            this.label3.TabIndex = 66;
            this.label3.Text = "Factura";
            // 
            // labelCedula
            // 
            this.labelCedula.AutoSize = true;
            this.labelCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.labelCedula.Location = new System.Drawing.Point(13, 65);
            this.labelCedula.Name = "labelCedula";
            this.labelCedula.Size = new System.Drawing.Size(93, 13);
            this.labelCedula.TabIndex = 64;
            this.labelCedula.Text = "Nombre de cliente";
            // 
            // clienteFP
            // 
            this.clienteFP.Location = new System.Drawing.Point(13, 38);
            this.clienteFP.Name = "clienteFP";
            this.clienteFP.Size = new System.Drawing.Size(244, 20);
            this.clienteFP.TabIndex = 1;
            // 
            // P_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fechaLabel1);
            this.Controls.Add(this.fechaLabel);
            this.Controls.Add(this.clearPF);
            this.Controls.Add(this.imprimirPF);
            this.Controls.Add(this.commentPF);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.totalPF);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Name = "P_Factura";
            this.Size = new System.Drawing.Size(1075, 500);
            this.Load += new System.EventHandler(this.P_Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadFP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label fechaLabel1;
        private System.Windows.Forms.Label fechaLabel;
        private System.Windows.Forms.Button clearPF;
        private System.Windows.Forms.Button imprimirPF;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label totalPF;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox numFacturaBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button searchFP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown cantidadFP;
        private System.Windows.Forms.Button addFP;
        public System.Windows.Forms.DataGridView inventarioGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCedula;
        public System.Windows.Forms.TextBox clienteFP;
        private System.Windows.Forms.Button limpiarBtn;
        private System.Windows.Forms.Button buscarBtn;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox commentPF;
    }
}
