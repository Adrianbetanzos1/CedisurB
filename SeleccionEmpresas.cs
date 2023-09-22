using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CedisurB
{
    public partial class SeleccionEmpresas : Form
    {

        public string Message { get; set; }
        public int SelectedOption { get; private set; }

        public SeleccionEmpresas()
        {
            InitializeComponent();
        }   
        public void Eleccion(string message, string option1, string option2, string option3)
        {
            LblTexto.Text = message;
            BtnCedisur.Text = option1;
            BtnCiessa.Text = option2;
            BtnGicsa.Text = option3;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SelectedOption = 1;
            this.Close();
        }

        private void BtnCiessa_Click(object sender, EventArgs e)
        {
            SelectedOption = 2;
            this.Close();
        }

        private void BtnGicsa_Click(object sender, EventArgs e)
        {
            SelectedOption = 3;
            this.Close();
        }
    }
}
