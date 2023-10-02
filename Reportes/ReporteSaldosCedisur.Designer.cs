namespace CedisurB.Reportes
{
    partial class ReporteSaldosCedisur
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
            this.TxtFechaFinal = new System.Windows.Forms.TextBox();
            this.TxtFechainicio = new System.Windows.Forms.TextBox();
            this.TxtProveedor = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // TxtFechaFinal
            // 
            this.TxtFechaFinal.Location = new System.Drawing.Point(345, 269);
            this.TxtFechaFinal.Name = "TxtFechaFinal";
            this.TxtFechaFinal.Size = new System.Drawing.Size(100, 20);
            this.TxtFechaFinal.TabIndex = 6;
            this.TxtFechaFinal.Visible = false;
            // 
            // TxtFechainicio
            // 
            this.TxtFechainicio.Location = new System.Drawing.Point(345, 212);
            this.TxtFechainicio.Name = "TxtFechainicio";
            this.TxtFechainicio.Size = new System.Drawing.Size(100, 20);
            this.TxtFechainicio.TabIndex = 5;
            this.TxtFechainicio.Visible = false;
            // 
            // TxtProveedor
            // 
            this.TxtProveedor.Location = new System.Drawing.Point(356, 162);
            this.TxtProveedor.Name = "TxtProveedor";
            this.TxtProveedor.Size = new System.Drawing.Size(100, 20);
            this.TxtProveedor.TabIndex = 4;
            this.TxtProveedor.Visible = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CedisurB.Reportes.Report9.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(657, 450);
            this.reportViewer1.TabIndex = 7;
            // 
            // ReporteSaldosCedisur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.TxtFechaFinal);
            this.Controls.Add(this.TxtFechainicio);
            this.Controls.Add(this.TxtProveedor);
            this.Name = "ReporteSaldosCedisur";
            this.Text = "ReporteSaldosCedisur";
            this.Load += new System.EventHandler(this.ReporteSaldosCedisur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TxtFechaFinal;
        public System.Windows.Forms.TextBox TxtFechainicio;
        public System.Windows.Forms.TextBox TxtProveedor;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}