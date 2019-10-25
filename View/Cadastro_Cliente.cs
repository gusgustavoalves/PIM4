using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Dao.Conexao con = new Dao.Conexao();

            cad.SetNome(txt_Nome.Text);
            cad.SetEnd(txt_End.Text);
            cad.SetCPF(txt_CPF.Text);




            //con.Conectar();
            
        }
    }
}
