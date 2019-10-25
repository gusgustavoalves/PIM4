using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho21_10_2019_1ponto.View;

namespace Trabalho21_10_2019_1ponto
{
    public partial class Sistema : Form
    {
        private Form _ojbForm; 
        View.Cadastro_Cliente Cadcliente = new View.Cadastro_Cliente();
        public Sistema()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ojbForm?.Close();

            _ojbForm = new Cadastro_Cliente
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            Panel_Sistema.Controls.Add(_ojbForm);
            _ojbForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
