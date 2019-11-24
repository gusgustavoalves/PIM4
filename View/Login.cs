using System;
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

namespace PIM.View
{
    public partial class frmLogin : Form
    {
        Model.Logar log = new Model.Logar();
        Dao.LoginBD loginbd = new Dao.LoginBD();
        frmSistema Sistema = new frmSistema();
        public frmLogin()
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

        private void NomeSis_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                Application.Exit();

        }
    }
}

