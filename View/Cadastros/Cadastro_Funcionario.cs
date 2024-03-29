﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM.Model;
using PIM.Dao;
using PIM;
using PIM.View;
using PIM.View.Cadastros;

namespace PIM.View
{
    public partial class frmCadastro_funcionario : Form
    {
        public frmCadastro_funcionario()
        {
            InitializeComponent();
        }

        private void Form_Cadastro_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void button_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
        }

        private void txt_CPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txt_CPF_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxNome_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btn_Sair_ENTREGAS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxSexo_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            Model.Cadastro_FuncionarioM cad = new Model.Cadastro_FuncionarioM();
            Dao.Cadastra_ClienteD cli = new Dao.Cadastra_ClienteD();

            cad.SetNome(textBoxNome.Text);
            cad.SetEnd(richTextBoxEndereco.Text);
            cad.SetCPF(textBoxCpf.Text);


            if (textBoxNome.Text != "" && richTextBoxEndereco.Text != "" && textBoxCpf.Text != "")
            {
                if (cad.GetCPF() != "" && cad.GetCPF() != null)
                {
                    if (cli.VerCliente(cad))
                    {
                        MessageBox.Show("Cliente Ja cadastrado !!!");
                    }
                    else
                    {
                        cli.CadastraCliente(cad);
                        MessageBox.Show("Cliente Cadastrado com Sucesso !!!");
                    }
                }
                else
                {
                    MessageBox.Show("Verifique o CPF digitado !!!");
                }
            }
            else
            {
                MessageBox.Show("Nenhum campo pode ser vazio !!!!");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisa_Funcionario fun = new frmPesquisa_Funcionario();
            fun.Show();
        }
    }
}
