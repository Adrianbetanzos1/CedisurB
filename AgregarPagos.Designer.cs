namespace CedisurB
{
    partial class AgregarPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarPagos));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombrePro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombreFactura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSaldoPendiente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSaldoUSD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtImporteUSD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtImporteMXP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtNumContrato = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtNumeroCuenta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DTPFechaPago = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.TxtDolar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.CbSPEI = new System.Windows.Forms.CheckedListBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TxtAbono = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.PictureBox3);
            this.panel1.Controls.Add(this.BtnVolver);
            this.panel1.Controls.Add(this.PictureBox2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 52);
            this.panel1.TabIndex = 7;
            // 
            // PictureBox3
            // 
            this.PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox3.Image")));
            this.PictureBox3.Location = new System.Drawing.Point(1174, 11);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(41, 34);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox3.TabIndex = 52;
            this.PictureBox3.TabStop = false;
            this.PictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // BtnVolver
            // 
            this.BtnVolver.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.Location = new System.Drawing.Point(0, 0);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(153, 52);
            this.BtnVolver.TabIndex = 8;
            this.BtnVolver.Text = "Volver a la ventana anterior";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(1214, 3);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(58, 42);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox2.TabIndex = 2;
            this.PictureBox2.TabStop = false;
            this.PictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(422, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 59);
            this.label1.TabIndex = 8;
            this.label1.Text = "AGREGAR PAGOS";
            // 
            // TxtNombrePro
            // 
            this.TxtNombrePro.Enabled = false;
            this.TxtNombrePro.Location = new System.Drawing.Point(474, 324);
            this.TxtNombrePro.Name = "TxtNombrePro";
            this.TxtNombrePro.Size = new System.Drawing.Size(333, 20);
            this.TxtNombrePro.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(469, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "NOMBRE DEL PROVEEDOR";
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(53, 324);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(333, 20);
            this.TxtID.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(48, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID DEL PROVEEDOR";
            // 
            // TxtNombreFactura
            // 
            this.TxtNombreFactura.Enabled = false;
            this.TxtNombreFactura.Location = new System.Drawing.Point(54, 239);
            this.TxtNombreFactura.Name = "TxtNombreFactura";
            this.TxtNombreFactura.Size = new System.Drawing.Size(333, 20);
            this.TxtNombreFactura.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(49, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "NOMBRE DE LA FACTURA";
            // 
            // txtSaldoPendiente
            // 
            this.txtSaldoPendiente.Enabled = false;
            this.txtSaldoPendiente.Location = new System.Drawing.Point(474, 239);
            this.txtSaldoPendiente.Name = "txtSaldoPendiente";
            this.txtSaldoPendiente.Size = new System.Drawing.Size(333, 20);
            this.txtSaldoPendiente.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(469, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(278, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "SALDO PENDIENTE MXP";
            // 
            // txtSaldoUSD
            // 
            this.txtSaldoUSD.Enabled = false;
            this.txtSaldoUSD.Location = new System.Drawing.Point(894, 324);
            this.txtSaldoUSD.Name = "txtSaldoUSD";
            this.txtSaldoUSD.Size = new System.Drawing.Size(333, 20);
            this.txtSaldoUSD.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(889, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "SALDO PENDIENTE USD";
            // 
            // TxtImporteUSD
            // 
            this.TxtImporteUSD.Enabled = false;
            this.TxtImporteUSD.Location = new System.Drawing.Point(474, 490);
            this.TxtImporteUSD.Name = "TxtImporteUSD";
            this.TxtImporteUSD.Size = new System.Drawing.Size(333, 20);
            this.TxtImporteUSD.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(469, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 25);
            this.label7.TabIndex = 36;
            this.label7.Text = "IMPORTE PAGO USD";
            // 
            // TxtImporteMXP
            // 
            this.TxtImporteMXP.Location = new System.Drawing.Point(53, 490);
            this.TxtImporteMXP.Name = "TxtImporteMXP";
            this.TxtImporteMXP.Size = new System.Drawing.Size(333, 20);
            this.TxtImporteMXP.TabIndex = 35;
            this.TxtImporteMXP.Leave += new System.EventHandler(this.TxtImporteMXP_Leave_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(48, 462);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 25);
            this.label8.TabIndex = 34;
            this.label8.Text = "IMPORTE PAGO MXP";
            // 
            // TxtNumContrato
            // 
            this.TxtNumContrato.Location = new System.Drawing.Point(474, 563);
            this.TxtNumContrato.Name = "TxtNumContrato";
            this.TxtNumContrato.Size = new System.Drawing.Size(333, 20);
            this.TxtNumContrato.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(469, 535);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(325, 25);
            this.label9.TabIndex = 32;
            this.label9.Text = "NUMERO DE CONTRATO/OC";
            // 
            // TxtNumeroCuenta
            // 
            this.TxtNumeroCuenta.Location = new System.Drawing.Point(53, 563);
            this.TxtNumeroCuenta.Name = "TxtNumeroCuenta";
            this.TxtNumeroCuenta.Size = new System.Drawing.Size(333, 20);
            this.TxtNumeroCuenta.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(48, 535);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(243, 25);
            this.label10.TabIndex = 30;
            this.label10.Text = "NUMERO DE CUENTA";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(889, 462);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(193, 25);
            this.label12.TabIndex = 39;
            this.label12.Text = "FECHA DE PAGO";
            // 
            // DTPFechaPago
            // 
            this.DTPFechaPago.Location = new System.Drawing.Point(894, 490);
            this.DTPFechaPago.Name = "DTPFechaPago";
            this.DTPFechaPago.Size = new System.Drawing.Size(338, 20);
            this.DTPFechaPago.TabIndex = 38;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label21.ForeColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(948, 165);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(104, 17);
            this.label21.TabIndex = 43;
            this.label21.Text = "Coloque el valor";
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(1060, 128);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(130, 25);
            this.Button1.TabIndex = 40;
            this.Button1.Text = "Convertir";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // TxtDolar
            // 
            this.TxtDolar.Location = new System.Drawing.Point(951, 102);
            this.TxtDolar.Name = "TxtDolar";
            this.TxtDolar.Size = new System.Drawing.Size(333, 20);
            this.TxtDolar.TabIndex = 42;
            this.TxtDolar.Leave += new System.EventHandler(this.TxtDolar_Leave_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(1065, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 25);
            this.label13.TabIndex = 41;
            this.label13.Text = "USD HOY";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(889, 535);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 25);
            this.label15.TabIndex = 45;
            this.label15.Text = "SPEI";
            // 
            // CbSPEI
            // 
            this.CbSPEI.FormattingEnabled = true;
            this.CbSPEI.Items.AddRange(new object[] {
            "Dolar",
            "Peso Mexicano"});
            this.CbSPEI.Location = new System.Drawing.Point(894, 563);
            this.CbSPEI.Name = "CbSPEI";
            this.CbSPEI.Size = new System.Drawing.Size(183, 49);
            this.CbSPEI.TabIndex = 44;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(584, 634);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(128, 52);
            this.BtnAgregar.TabIndex = 50;
            this.BtnAgregar.Text = "Aplicar pago";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click_1);
            // 
            // TxtAbono
            // 
            this.TxtAbono.Enabled = false;
            this.TxtAbono.Location = new System.Drawing.Point(12, 70);
            this.TxtAbono.Name = "TxtAbono";
            this.TxtAbono.Size = new System.Drawing.Size(333, 20);
            this.TxtAbono.TabIndex = 51;
            this.TxtAbono.Visible = false;
            // 
            // AgregarPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1328, 720);
            this.Controls.Add(this.TxtAbono);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.CbSPEI);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TxtDolar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DTPFechaPago);
            this.Controls.Add(this.TxtImporteUSD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtImporteMXP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtNumContrato);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtNumeroCuenta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSaldoPendiente);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSaldoUSD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtNombreFactura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNombrePro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarPagos";
            this.Load += new System.EventHandler(this.AgregarPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtSaldoPendiente;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtSaldoUSD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.DateTimePicker DTPFechaPago;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button Button1;
        public System.Windows.Forms.TextBox TxtDolar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button BtnAgregar;
        public System.Windows.Forms.TextBox TxtNombrePro;
        public System.Windows.Forms.TextBox TxtID;
        public System.Windows.Forms.TextBox TxtNombreFactura;
        public System.Windows.Forms.TextBox TxtImporteUSD;
        public System.Windows.Forms.TextBox TxtImporteMXP;
        public System.Windows.Forms.TextBox TxtNumContrato;
        public System.Windows.Forms.TextBox TxtNumeroCuenta;
        public System.Windows.Forms.CheckedListBox CbSPEI;
        public System.Windows.Forms.TextBox TxtAbono;
        private System.Windows.Forms.PictureBox PictureBox3;
    }
}