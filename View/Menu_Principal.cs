﻿using System;
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
using PIM.View.Finanças;
using PIM.View.Cadastros;
using PIM.View.Coleta;

namespace PIM
{
    public partial class frmSistema : Form
    {
        private const string Caption = "Aviso";
        private Form _ojbForm;
        public frmSistema()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ojbForm?.Close();

            _ojbForm = new frmClienteFornecedores
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

            _ojbForm = new frmColeta
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
            if (MessageBox.Show("Deseja encerrar a aplicação ?", Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ToolStripMenuItem_Nova_Coleta_Click(object sender, EventArgs e)
        {

        }


        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*_ojbForm?.Close();

            _ojbForm = new frmCadastro_Usuario
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            Panel_Sistema.Controls.Add(_ojbForm);
            _ojbForm.Show();*/
            frmCadastro_Usuario cadusu = new frmCadastro_Usuario();
            cadusu.Show();
        }

        private void veiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*_ojbForm?.Close();

            _ojbForm = new frmCadastro_Veiculo
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            Panel_Sistema.Controls.Add(_ojbForm);
            _ojbForm.Show();*/
            frmCadastro_Veiculo veiculo = new frmCadastro_Veiculo();
            veiculo.Show();
        }

        private void entregasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _ojbForm?.Close();

            _ojbForm = new frmEntregas
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            Panel_Sistema.Controls.Add(_ojbForm);
            _ojbForm.Show();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ojbForm?.Close();

            _ojbForm = new frmCadastro_funcionario
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            Panel_Sistema.Controls.Add(_ojbForm);
            _ojbForm.Show();
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ojbForm?.Close();

            _ojbForm = new PIM.View.Finanças.frmGridContas_A_Pagar
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            Panel_Sistema.Controls.Add(_ojbForm);
            _ojbForm.Show();
        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ojbForm?.Close();

            _ojbForm = new frmGridContas_A_Receber
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            Panel_Sistema.Controls.Add(_ojbForm);
            _ojbForm.Show();
        }

        private void estoqueDePeçasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ojbForm?.Close();

            _ojbForm = new PIM.View.Estoque_De_Peças.frmEstoquePecas
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
