using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho21_10_2019_1ponto.Model;
using Trabalho21_10_2019_1ponto.Dao;

namespace Trabalho21_10_2019_1ponto.View
{
    public partial class Cadastro_Cliente : Form
    {
        public Cadastro_Cliente()
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
            Model.Cadastro cad = new Model.Cadastro();
            Dao.Cadastra_Cliente cli = new Dao.Cadastra_Cliente();
                
            cad.SetNome(txt_Nome.Text);
            cad.SetEnd(txt_End.Text);
            cad.SetCPF(txt_CPF.Text);


            if (txt_Nome.Text != "" && txt_CPF.Text != "" && txt_End.Text != "")
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
                MessageBox.Show("Nenhum campo pode ser vazio !!!!");
            }


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
    }
}
