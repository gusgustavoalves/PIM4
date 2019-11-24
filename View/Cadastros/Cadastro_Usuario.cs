using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.View.Cadastros
{
    public partial class frmCadastro_Usuario : Form
    {
        public frmCadastro_Usuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Model.Cadastro_UsuarioM musu = new Model.Cadastro_UsuarioM();
            Dao.Cadastra_UsuarioD dusu = new Dao.Cadastra_UsuarioD();
            Dao.LoginBD l = new Dao.LoginBD();

            musu.SetUsuario(TextBoxUsuario.Text);
            if(TextBoxSenha.Text == TextBoxConfirmarSenha.Text)
            {
                musu.SetSenha(TextBoxSenha.Text);
                if (!dusu.Validausuario(musu))
                {
                    dusu.CadastraUsuario(musu);
                    MessageBox.Show("Usuario cadastrado com sucesso !!!");
                    TextBoxUsuario.Clear();
                    TextBoxSenha.Clear();
                    TextBoxConfirmarSenha.Clear();
                }
                else
                {
                    MessageBox.Show("Usuario ja cadastrado !!!");
                }

            } else
            {
                MessageBox.Show("Senhas não conferem !");
            }
        }
    }
}
