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
    public partial class Tela_Login : Form
    {
        Model.Logar log = new Model.Logar();
        Dao.LoginBD loginbd = new Dao.LoginBD();
        Sistema Sistema = new Sistema();
        public Tela_Login()
        {
            InitializeComponent();
        }

        private void button_Logar_Click(object sender, EventArgs e)
        {
            log.SetUsuario(txt_Usuario.Text);
            log.SetSenha(txt_Senha.Text);
            if (txt_Usuario.Text != "" && txt_Senha.Text != "")
            {
                if (loginbd.Validausuario(log))
                {
                    this.Hide();
                    Sistema.Show();
                }
                else
                {
                    MessageBox.Show("Usuario ou Senha inválidos");                    
                }
            }
            else
            {
                MessageBox.Show("Usuario e Senha não podem ser vazios");               
            }
        }

        private void txt_Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Nome_Click(object sender, EventArgs e)
        {

        }

        private void Tela_Login_Load(object sender, EventArgs e)
        {

        }
    }
}

