using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM.View;
using PIM.View.Coleta;
using PIM.View.Cadastros;

namespace PIM
{
    public partial class Sistema : Form
    {
        private Form _ojbForm; 
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

        private void Sistema_Load(object sender, EventArgs e)
        {

        }

        private void testeDeConexaoComBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dao.Conexao con = new Dao.Conexao();
            con.Testeconection();

        }

        private void conexaoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_Coleta_Click(object sender, EventArgs e)
        {
            _ojbForm?.Close();

            _ojbForm = new Coleta
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            Panel_Sistema.Controls.Add(_ojbForm);
            _ojbForm.Show();
        
        }


        private void ToolStripMenuItem_Sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                Application.Exit();
        }

        private void ToolStripMenuItem_Nova_Coleta_Click(object sender, EventArgs e)
        {

        }


        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void veiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ojbForm?.Close();

            _ojbForm = new Cadastro_Veiculo
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            Panel_Sistema.Controls.Add(_ojbForm);
            _ojbForm.Show();
        }

        private void entregasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _ojbForm?.Close();

            _ojbForm = new Entregas
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            Panel_Sistema.Controls.Add(_ojbForm);
            _ojbForm.Show();
        }
    }
}
