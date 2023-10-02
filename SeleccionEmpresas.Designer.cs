namespace CedisurB
{
    partial class SeleccionEmpresas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCedisur = new System.Windows.Forms.Button();
            this.BtnCiessa = new System.Windows.Forms.Button();
            this.BtnGicsa = new System.Windows.Forms.Button();
            this.LblTexto = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 52);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(95, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "SELECCION DE EMPRESA";
            // 
            // BtnCedisur
            // 
            this.BtnCedisur.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCedisur.Location = new System.Drawing.Point(60, 155);
            this.BtnCedisur.Name = "BtnCedisur";
            this.BtnCedisur.Size = new System.Drawing.Size(128, 58);
            this.BtnCedisur.TabIndex = 71;
            this.BtnCedisur.Text = "CEDISUR";
            this.BtnCedisur.UseVisualStyleBackColor = true;
            this.BtnCedisur.Click += new System.EventHandler(this.Button2_Click);
            // 
            // BtnCiessa
            // 
            this.BtnCiessa.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCiessa.Location = new System.Drawing.Point(231, 155);
            this.BtnCiessa.Name = "BtnCiessa";
            this.BtnCiessa.Size = new System.Drawing.Size(128, 58);
            this.BtnCiessa.TabIndex = 72;
            this.BtnCiessa.Text = "CIESSA";
            this.BtnCiessa.UseVisualStyleBackColor = true;
            this.BtnCiessa.Click += new System.EventHandler(this.BtnCiessa_Click);
            // 
            // BtnGicsa
            // 
            this.BtnGicsa.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGicsa.Location = new System.Drawing.Point(401, 155);
            this.BtnGicsa.Name = "BtnGicsa";
            this.BtnGicsa.Size = new System.Drawing.Size(128, 58);
            this.BtnGicsa.TabIndex = 73;
            this.BtnGicsa.Text = "GICSA";
            this.BtnGicsa.UseVisualStyleBackColor = true;
            this.BtnGicsa.Click += new System.EventHandler(this.BtnGicsa_Click);
            // 
            // LblTexto
            // 
            this.LblTexto.AutoSize = true;
            this.LblTexto.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTexto.ForeColor = System.Drawing.SystemColors.Control;
            this.LblTexto.Location = new System.Drawing.Point(57, 116);
            this.LblTexto.Name = "LblTexto";
            this.LblTexto.Size = new System.Drawing.Size(17, 18);
            this.LblTexto.TabIndex = 74;
            this.LblTexto.Text = "*";
            // 
            // SeleccionEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(651, 305);
            this.Controls.Add(this.LblTexto);
            this.Controls.Add(this.BtnGicsa);
            this.Controls.Add(this.BtnCiessa);
            this.Controls.Add(this.BtnCedisur);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeleccionEmpresas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeleccionEmpresas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCedisur;
        private System.Windows.Forms.Button BtnCiessa;
        private System.Windows.Forms.Button BtnGicsa;
        private System.Windows.Forms.Label LblTexto;
    }
}