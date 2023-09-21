namespace CedisurB.Reportes
{
    partial class ReporteSaldoGeneral
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TxtFechaFinal = new System.Windows.Forms.TextBox();
            this.TxtFechainicio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CedisurB.Reportes.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // TxtFechaFinal
            // 
            this.TxtFechaFinal.Location = new System.Drawing.Point(658, 123);
            this.TxtFechaFinal.Name = "TxtFechaFinal";
            this.TxtFechaFinal.Size = new System.Drawing.Size(100, 20);
            this.TxtFechaFinal.TabIndex = 5;
            this.TxtFechaFinal.Visible = false;
            // 
            // TxtFechainicio
            // 
            this.TxtFechainicio.Location = new System.Drawing.Point(658, 66);
            this.TxtFechainicio.Name = "TxtFechainicio";
            this.TxtFechainicio.Size = new System.Drawing.Size(100, 20);
            this.TxtFechainicio.TabIndex = 4;
            this.TxtFechainicio.Visible = false;
            // 
            // ReporteSaldoGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.TxtFechaFinal);
            this.Controls.Add(this.TxtFechainicio);
            this.Name = "ReporteSaldoGeneral";
            this.Text = "ReporteSaldoGeneral";
            this.Load += new System.EventHandler(this.ReporteSaldoGeneral_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public System.Windows.Forms.TextBox TxtFechaFinal;
        public System.Windows.Forms.TextBox TxtFechainicio;
    }
}