﻿namespace CedisurB
{
    partial class AgregarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProveedor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIDProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombreProv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtRfc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DTPFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.CbTipo = new System.Windows.Forms.CheckedListBox();
            this.CbMoneda = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.CLBEmpresa = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.PictureBox3);
            this.panel1.Controls.Add(this.BtnVolver);
            this.panel1.Controls.Add(this.PictureBox2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1131, 52);
            this.panel1.TabIndex = 2;
            // 
            // PictureBox3
            // 
            this.PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox3.Image")));
            this.PictureBox3.Location = new System.Drawing.Point(1015, 11);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(41, 34);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox3.TabIndex = 16;
            this.PictureBox3.TabStop = false;
            this.PictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // BtnVolver
            // 
            this.BtnVolver.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.Location = new System.Drawing.Point(0, 0);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(128, 52);
            this.BtnVolver.TabIndex = 8;
            this.BtnVolver.Text = "Volver al menú";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(1053, 3);
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
            this.label1.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(347, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "AGREGAR PROVEEDOR";
            // 
            // TxtIDProveedor
            // 
            this.TxtIDProveedor.Location = new System.Drawing.Point(90, 249);
            this.TxtIDProveedor.Name = "TxtIDProveedor";
            this.TxtIDProveedor.Size = new System.Drawing.Size(333, 20);
            this.TxtIDProveedor.TabIndex = 5;
            this.TxtIDProveedor.Leave += new System.EventHandler(this.TxtIDProveedor_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(85, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID DEL PROVEEDOR";
            // 
            // TxtNombreProv
            // 
            this.TxtNombreProv.Location = new System.Drawing.Point(511, 249);
            this.TxtNombreProv.Name = "TxtNombreProv";
            this.TxtNombreProv.Size = new System.Drawing.Size(333, 20);
            this.TxtNombreProv.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(506, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "NOMBRE DEL PROVEEDOR";
            // 
            // TxtRfc
            // 
            this.TxtRfc.Location = new System.Drawing.Point(90, 325);
            this.TxtRfc.Name = "TxtRfc";
            this.TxtRfc.Size = new System.Drawing.Size(333, 20);
            this.TxtRfc.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(85, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "RFC DEL PROVEEDOR";
            // 
            // DTPFecha
            // 
            this.DTPFecha.Location = new System.Drawing.Point(897, 249);
            this.DTPFecha.Name = "DTPFecha";
            this.DTPFecha.Size = new System.Drawing.Size(226, 20);
            this.DTPFecha.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(892, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "FECHA DE REGISTRO";
            // 
            // CbTipo
            // 
            this.CbTipo.CheckOnClick = true;
            this.CbTipo.FormattingEnabled = true;
            this.CbTipo.Items.AddRange(new object[] {
            "Proveedor",
            "Acreedor"});
            this.CbTipo.Location = new System.Drawing.Point(511, 321);
            this.CbTipo.Name = "CbTipo";
            this.CbTipo.Size = new System.Drawing.Size(179, 49);
            this.CbTipo.TabIndex = 12;
            this.CbTipo.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CbTipo_ItemCheck);
            // 
            // CbMoneda
            // 
            this.CbMoneda.CheckOnClick = true;
            this.CbMoneda.FormattingEnabled = true;
            this.CbMoneda.Items.AddRange(new object[] {
            "Peso mexicano",
            "Dolar americano"});
            this.CbMoneda.Location = new System.Drawing.Point(897, 337);
            this.CbMoneda.Name = "CbMoneda";
            this.CbMoneda.Size = new System.Drawing.Size(183, 49);
            this.CbMoneda.TabIndex = 13;
            this.CbMoneda.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CbMoneda_ItemCheck);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(506, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "TIPO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(892, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "MONEDA DE PAGO";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(511, 414);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(128, 52);
            this.BtnAgregar.TabIndex = 9;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // CLBEmpresa
            // 
            this.CLBEmpresa.CheckOnClick = true;
            this.CLBEmpresa.FormattingEnabled = true;
            this.CLBEmpresa.Items.AddRange(new object[] {
            "CEDISUR",
            "CIESSA",
            "GICSSA"});
            this.CLBEmpresa.Location = new System.Drawing.Point(90, 414);
            this.CLBEmpresa.Name = "CLBEmpresa";
            this.CLBEmpresa.Size = new System.Drawing.Size(179, 49);
            this.CLBEmpresa.TabIndex = 16;
            this.CLBEmpresa.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBEmpresa_ItemCheck);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(85, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "EMPRESA";
            // 
            // AgregarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1166, 523);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CLBEmpresa);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CbMoneda);
            this.Controls.Add(this.CbTipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DTPFecha);
            this.Controls.Add(this.TxtRfc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNombreProv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtIDProveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarProveedor";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIDProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombreProv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtRfc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DTPFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox CbTipo;
        private System.Windows.Forms.CheckedListBox CbMoneda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.PictureBox PictureBox3;
        private System.Windows.Forms.CheckedListBox CLBEmpresa;
        private System.Windows.Forms.Label label8;
    }
}