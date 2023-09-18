﻿using CedisurB.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CedisurB
{
    public partial class VerUsuarios : Form
    {
        private readonly SqlConnection conexion = new SqlConnection("server=DESKTOP-717JV41\\SQLEXPRESS ; database=cedisur ; integrated security = true");

        public VerUsuarios()
        {
            InitializeComponent();
        }


        private void VerUsuarios_Load(object sender, EventArgs e)
        {
            DGVusuarios.DataSource = Usuarios.MostrarUsuario();
            DGVusuarios.Columns[0].HeaderText = "ID usuario";
            DGVusuarios.Columns[1].HeaderText = "Nombre completo del usuario";
            DGVusuarios.Columns[2].HeaderText = "Nombre de usuario";
            DGVusuarios.Columns[3].HeaderText = "Contraseña";
            DGVusuarios.Columns[4].HeaderText = "Nivel de seguridad";
            DGVusuarios.Columns[5].HeaderText = "Email";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (DGVusuarios.RowCount == 0)
            {
                MessageBox.Show("No hay datos existentes");
            }
            else if (MessageBox.Show("Estás seguro que deseas eliminar a este usuario?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                conexion.Open();
                string query = "delete from Usuarios where ID_usuario = " + DGVusuarios.SelectedRows[0].Cells[0].Value.ToString();
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuario eliminado correctamente");
                conexion.Close();

                this.Close();
                VerUsuarios verUsuarios = new VerUsuarios();
                verUsuarios.Show();
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DGVusuarios.RowCount == 0)
            {
                MessageBox.Show("No hay datos existentes");
            }
            else
            {
                var usuarios = new EditarUsuarios
                {
                    ParentForm = this
                };
                usuarios.TxtIDUsuario.Text = DGVusuarios.SelectedRows[0].Cells[0].Value.ToString();
                usuarios.TxtNombreCompleto.Text = DGVusuarios.SelectedRows[0].Cells[1].Value.ToString();
                usuarios.TxtNombre.Text = DGVusuarios.SelectedRows[0].Cells[2].Value.ToString();
                usuarios.TxtContraseña.Text = DGVusuarios.SelectedRows[0].Cells[3].Value.ToString();
                usuarios.CbTipoAutorizacion.SelectedValue = DGVusuarios.SelectedRows[0].Cells[4].Value.ToString();
                usuarios.TxtEmail.Text = DGVusuarios.SelectedRows[0].Cells[5].Value.ToString();

                this.Hide();
                usuarios.ShowDialog();
            }
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
