namespace CedisurB
{
    partial class VerFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerFacturas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnBuscarID = new System.Windows.Forms.Button();
            this.TxtBuscarID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DGVfacturas = new System.Windows.Forms.DataGridView();
            this.BtnReporte = new System.Windows.Forms.Button();
            this.BtnPagar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.BtnMas = new System.Windows.Forms.Button();
            this.DTPInicio = new System.Windows.Forms.DateTimePicker();
            this.DTPfinal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnBuscarFecha = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.CLBEmpresa = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVfacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.PictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnVolver);
            this.panel1.Controls.Add(this.PictureBox2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 52);
            this.panel1.TabIndex = 8;
            // 
            // PictureBox3
            // 
            this.PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox3.Image")));
            this.PictureBox3.Location = new System.Drawing.Point(1139, 8);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(41, 34);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox3.TabIndex = 50;
            this.PictureBox3.TabStop = false;
            this.PictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(425, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "FACTURAS GENERADAS";
            // 
            // BtnVolver
            // 
            this.BtnVolver.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.Location = new System.Drawing.Point(0, 0);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(115, 52);
            this.BtnVolver.TabIndex = 8;
            this.BtnVolver.Text = "Volver al menú";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(1176, 3);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(58, 42);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox2.TabIndex = 2;
            this.PictureBox2.TabStop = false;
            this.PictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // BtnBuscarID
            // 
            this.BtnBuscarID.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarID.Location = new System.Drawing.Point(755, 108);
            this.BtnBuscarID.Name = "BtnBuscarID";
            this.BtnBuscarID.Size = new System.Drawing.Size(103, 34);
            this.BtnBuscarID.TabIndex = 44;
            this.BtnBuscarID.Text = "Buscar";
            this.BtnBuscarID.UseVisualStyleBackColor = true;
            this.BtnBuscarID.Click += new System.EventHandler(this.BtnBuscarID_Click);
            // 
            // TxtBuscarID
            // 
            this.TxtBuscarID.Location = new System.Drawing.Point(452, 123);
            this.TxtBuscarID.Name = "TxtBuscarID";
            this.TxtBuscarID.Size = new System.Drawing.Size(288, 20);
            this.TxtBuscarID.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(437, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 19);
            this.label2.TabIndex = 42;
            this.label2.Text = "BUSCAR POR NOMBRE PROVEEDOR";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(328, 106);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(103, 37);
            this.BtnBuscar.TabIndex = 41;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(17, 123);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(305, 20);
            this.TxtBusqueda.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 19);
            this.label4.TabIndex = 39;
            this.label4.Text = "BUSCAR POR NOMBRE DE FACTURA";
            // 
            // DGVfacturas
            // 
            this.DGVfacturas.AllowUserToAddRows = false;
            this.DGVfacturas.AllowUserToDeleteRows = false;
            this.DGVfacturas.AllowUserToResizeColumns = false;
            this.DGVfacturas.AllowUserToResizeRows = false;
            this.DGVfacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVfacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVfacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVfacturas.Location = new System.Drawing.Point(12, 171);
            this.DGVfacturas.Name = "DGVfacturas";
            this.DGVfacturas.ReadOnly = true;
            this.DGVfacturas.RowHeadersVisible = false;
            this.DGVfacturas.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            this.DGVfacturas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVfacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVfacturas.Size = new System.Drawing.Size(1099, 402);
            this.DGVfacturas.TabIndex = 45;
            this.DGVfacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVfacturas_CellContentClick);
            this.DGVfacturas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGVfacturas_CellFormatting);
            // 
            // BtnReporte
            // 
            this.BtnReporte.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporte.Location = new System.Drawing.Point(17, 180);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(128, 58);
            this.BtnReporte.TabIndex = 48;
            this.BtnReporte.Text = "d";
            this.BtnReporte.UseVisualStyleBackColor = true;
            this.BtnReporte.Visible = false;
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // BtnPagar
            // 
            this.BtnPagar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPagar.Location = new System.Drawing.Point(1126, 300);
            this.BtnPagar.Name = "BtnPagar";
            this.BtnPagar.Size = new System.Drawing.Size(120, 58);
            this.BtnPagar.TabIndex = 47;
            this.BtnPagar.Text = "Realizar pago";
            this.BtnPagar.UseVisualStyleBackColor = true;
            this.BtnPagar.Click += new System.EventHandler(this.BtnPagar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(1126, 515);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(120, 58);
            this.BtnEditar.TabIndex = 46;
            this.BtnEditar.Text = "Editar datos factura";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(1126, 406);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(120, 58);
            this.Button1.TabIndex = 49;
            this.Button1.Text = "Generar reporte";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BtnMas
            // 
            this.BtnMas.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMas.Location = new System.Drawing.Point(856, 543);
            this.BtnMas.Name = "BtnMas";
            this.BtnMas.Size = new System.Drawing.Size(128, 47);
            this.BtnMas.TabIndex = 50;
            this.BtnMas.Text = "Cargar mas registros";
            this.BtnMas.UseVisualStyleBackColor = true;
            this.BtnMas.Visible = false;
            this.BtnMas.Click += new System.EventHandler(this.BtnMas_Click);
            // 
            // DTPInicio
            // 
            this.DTPInicio.Location = new System.Drawing.Point(931, 106);
            this.DTPInicio.Name = "DTPInicio";
            this.DTPInicio.Size = new System.Drawing.Size(180, 20);
            this.DTPInicio.TabIndex = 51;
            // 
            // DTPfinal
            // 
            this.DTPfinal.Location = new System.Drawing.Point(931, 132);
            this.DTPfinal.Name = "DTPfinal";
            this.DTPfinal.Size = new System.Drawing.Size(180, 20);
            this.DTPfinal.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(869, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 53;
            this.label3.Text = "POR FECHA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(870, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 54;
            this.label5.Text = "Inicial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(870, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 55;
            this.label6.Text = "Final";
            // 
            // BtnBuscarFecha
            // 
            this.BtnBuscarFecha.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarFecha.Location = new System.Drawing.Point(1126, 99);
            this.BtnBuscarFecha.Name = "BtnBuscarFecha";
            this.BtnBuscarFecha.Size = new System.Drawing.Size(109, 54);
            this.BtnBuscarFecha.TabIndex = 56;
            this.BtnBuscarFecha.Text = "Buscar por fecha";
            this.BtnBuscarFecha.UseVisualStyleBackColor = true;
            this.BtnBuscarFecha.Click += new System.EventHandler(this.BtnBuscarFecha_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(1117, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 19);
            this.label7.TabIndex = 58;
            this.label7.Text = " POR EMPRESA";
            // 
            // CLBEmpresa
            // 
            this.CLBEmpresa.CheckOnClick = true;
            this.CLBEmpresa.FormattingEnabled = true;
            this.CLBEmpresa.Items.AddRange(new object[] {
            "CEDISUR",
            "GICSSA",
            "CIESSA"});
            this.CLBEmpresa.Location = new System.Drawing.Point(1124, 205);
            this.CLBEmpresa.Name = "CLBEmpresa";
            this.CLBEmpresa.Size = new System.Drawing.Size(122, 49);
            this.CLBEmpresa.TabIndex = 57;
            this.CLBEmpresa.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBEmpresa_ItemCheck);
            this.CLBEmpresa.SelectedIndexChanged += new System.EventHandler(this.CLBEmpresa_SelectedIndexChanged);
            // 
            // VerFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1259, 596);
            this.Controls.Add(this.DGVfacturas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CLBEmpresa);
            this.Controls.Add(this.BtnBuscarFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DTPfinal);
            this.Controls.Add(this.DTPInicio);
            this.Controls.Add(this.BtnMas);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.BtnPagar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnBuscarID);
            this.Controls.Add(this.TxtBuscarID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnReporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerFacturas";
            this.Load += new System.EventHandler(this.VerFacturas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVfacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.Button BtnBuscarID;
        private System.Windows.Forms.TextBox TxtBuscarID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView DGVfacturas;
        private System.Windows.Forms.Button BtnReporte;
        private System.Windows.Forms.Button BtnPagar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.PictureBox PictureBox3;
        private System.Windows.Forms.Button BtnMas;
        private System.Windows.Forms.DateTimePicker DTPInicio;
        private System.Windows.Forms.DateTimePicker DTPfinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnBuscarFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox CLBEmpresa;
    }
}