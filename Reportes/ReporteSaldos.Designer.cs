namespace CedisurB.Reportes
{
    partial class ReporteSaldos
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
            this.components = new System.ComponentModel.Container();
            this.dTMostrarSaldosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSistemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSistema = new CedisurB.Reportes.DsSistema();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dT_MostrarSaldosTableAdapter = new CedisurB.Reportes.DsSistemaTableAdapters.DT_MostrarSaldosTableAdapter();
            this.TxtProveedor = new System.Windows.Forms.TextBox();
            this.TxtFechainicio = new System.Windows.Forms.TextBox();
            this.TxtFechaFinal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dTMostrarSaldosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).BeginInit();
            this.SuspendLayout();
            // 
            // dTMostrarSaldosBindingSource
            // 
            this.dTMostrarSaldosBindingSource.DataMember = "DT_MostrarSaldos";
            this.dTMostrarSaldosBindingSource.DataSource = this.dsSistemaBindingSource;
            // 
            // dsSistemaBindingSource
            // 
            this.dsSistemaBindingSource.DataSource = this.dsSistema;
            this.dsSistemaBindingSource.Position = 0;
            // 
            // dsSistema
            // 
            this.dsSistema.DataSetName = "DsSistema";
            this.dsSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CedisurB.Reportes.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(727, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dT_MostrarSaldosTableAdapter
            // 
            this.dT_MostrarSaldosTableAdapter.ClearBeforeFill = true;
            // 
            // TxtProveedor
            // 
            this.TxtProveedor.Location = new System.Drawing.Point(942, 140);
            this.TxtProveedor.Name = "TxtProveedor";
            this.TxtProveedor.Size = new System.Drawing.Size(100, 20);
            this.TxtProveedor.TabIndex = 1;
            this.TxtProveedor.Visible = false;
            // 
            // TxtFechainicio
            // 
            this.TxtFechainicio.Location = new System.Drawing.Point(931, 190);
            this.TxtFechainicio.Name = "TxtFechainicio";
            this.TxtFechainicio.Size = new System.Drawing.Size(100, 20);
            this.TxtFechainicio.TabIndex = 2;
            this.TxtFechainicio.Visible = false;
            // 
            // TxtFechaFinal
            // 
            this.TxtFechaFinal.Location = new System.Drawing.Point(931, 247);
            this.TxtFechaFinal.Name = "TxtFechaFinal";
            this.TxtFechaFinal.Size = new System.Drawing.Size(100, 20);
            this.TxtFechaFinal.TabIndex = 3;
            this.TxtFechaFinal.Visible = false;
            // 
            // ReporteSaldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.TxtFechaFinal);
            this.Controls.Add(this.TxtFechainicio);
            this.Controls.Add(this.TxtProveedor);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteSaldos";
            this.Text = "ReporteSaldos";
            this.Load += new System.EventHandler(this.ReporteSaldos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dTMostrarSaldosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DsSistema dsSistema;
        private System.Windows.Forms.BindingSource dsSistemaBindingSource;
        private System.Windows.Forms.BindingSource dTMostrarSaldosBindingSource;
        private DsSistemaTableAdapters.DT_MostrarSaldosTableAdapter dT_MostrarSaldosTableAdapter;
        public System.Windows.Forms.TextBox TxtProveedor;
        public System.Windows.Forms.TextBox TxtFechainicio;
        public System.Windows.Forms.TextBox TxtFechaFinal;
    }
}