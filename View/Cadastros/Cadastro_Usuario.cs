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


        private void TextBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            textBoxUsuario.CharacterCasing = CharacterCasing.Upper;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            Model.Cadastro_UsuarioM musu = new Model.Cadastro_UsuarioM();
            Dao.Cadastra_UsuarioD dusu = new Dao.Cadastra_UsuarioD();
            Dao.LoginBD l = new Dao.LoginBD();

            musu.SetUsuario(textBoxUsuario.Text);
            if (textBoxSenha.Text == textBoxConfirmaSenha.Text)
            {
                musu.SetSenha(textBoxSenha.Text);
                if (!dusu.Validausuario(musu))
                {
                    dusu.CadastraUsuario(musu);
                    MessageBox.Show("Usuario cadastrado com sucesso !!!");
                    textBoxUsuario.Clear();
                    textBoxSenha.Clear();
                    textBoxConfirmaSenha.Clear();
                }
                else
                {
                    MessageBox.Show("Usuario ja cadastrado !!!");
                }

            }
            else
            {
                MessageBox.Show("Senhas não conferem !");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisa_Usuario pesusu = new frmPesquisa_Usuario();

            pesusu.Show();
        }
    }
}
