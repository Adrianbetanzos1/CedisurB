namespace CedisurB.Reportes
{
    partial class ReporteFiltrado
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsSistema = new CedisurB.Reportes.DsSistema();
            this.DT_MostrarFacturasActualizadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.verFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtFechaFinal = new System.Windows.Forms.TextBox();
            this.TxtFechainicio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DT_MostrarFacturasActualizadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verFacturasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CedisurB.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(747, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsSistema
            // 
            this.dsSistema.DataSetName = "DsSistema";
            this.dsSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DT_MostrarFacturasActualizadaBindingSource
            // 
            this.DT_MostrarFacturasActualizadaBindingSource.DataMember = "DT_MostrarFacturasActualizada";
            this.DT_MostrarFacturasActualizadaBindingSource.DataSource = this.dsSistema;
            // 
            // verFacturasBindingSource
            // 
            this.verFacturasBindingSource.DataSource = typeof(CedisurB.VerFacturas);
            // 
            // TxtFechaFinal
            // 
            this.TxtFechaFinal.Location = new System.Drawing.Point(823, 231);
            this.TxtFechaFinal.Name = "TxtFechaFinal";
            this.TxtFechaFinal.Size = new System.Drawing.Size(100, 20);
            this.TxtFechaFinal.TabIndex = 5;
            this.TxtFechaFinal.Visible = false;
            // 
            // TxtFechainicio
            // 
            this.TxtFechainicio.Location = new System.Drawing.Point(823, 174);
            this.TxtFechainicio.Name = "TxtFechainicio";
            this.TxtFechainicio.Size = new System.Drawing.Size(100, 20);
            this.TxtFechainicio.TabIndex = 4;
            this.TxtFechainicio.Visible = false;
            // 
            // ReporteFiltrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.TxtFechaFinal);
            this.Controls.Add(this.TxtFechainicio);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteFiltrado";
            this.Text = "ReporteFiltrado";
            this.Load += new System.EventHandler(this.ReporteFiltrado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DT_MostrarFacturasActualizadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verFacturasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DsSistema dsSistema;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DT_MostrarFacturasActualizadaBindingSource;
        private System.Windows.Forms.BindingSource verFacturasBindingSource;
        public System.Windows.Forms.TextBox TxtFechaFinal;
        public System.Windows.Forms.TextBox TxtFechainicio;
    }
}