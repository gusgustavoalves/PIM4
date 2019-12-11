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

            
            if (textBoxID.Text=="")
            {
                if (textBoxSenha.Text == textBoxConfirmaSenha.Text)
                {
                    if (textBoxSenha.Text != "" && textBoxConfirmaSenha.Text != "" && textBoxUsuario.Text != "")
                    {
                        musu.SetUsuario(textBoxUsuario.Text);
                        musu.SetSenha(textBoxSenha.Text);
                        if (!dusu.Validausuario(musu))
                        {
                            dusu.CadastraUsuario(musu);
                            MessageBox.Show("Usuario cadastrado com sucesso !!!");
                            textBoxID.Clear();
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
                        MessageBox.Show("Campos nao podem ser vazios !!");
                    }
                }
                else
                {
                    MessageBox.Show("Senhas não conferem !");
                }
            }
            else if(textBoxSenha.Text == textBoxConfirmaSenha.Text)
            {
                if (textBoxSenha.Text != "" && textBoxConfirmaSenha.Text != "") {
                    musu.SetId(textBoxID.Text);
                    musu.SetSenha(textBoxSenha.Text);
                    dusu.AlterarUsuario(musu);
                    MessageBox.Show("Senha Alterada com Sucesso !!!");
                    textBoxSenha.Clear();
                    textBoxConfirmaSenha.Clear();
                }
                else
                {
                    MessageBox.Show("Senhas não podem ser vazias !!");
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

            //pesusu.Show();

            if (pesusu.ShowDialog() != DialogResult.OK)
                return;

            textBoxID.Text = pesusu.Id.ToString();
            textBoxUsuario.Text = pesusu.Usuario;
            textBoxSenha.Text = pesusu.Senha;
            textBoxConfirmaSenha.Text = pesusu.Senha;
        }

        private void textBoxUsuario_TextChanged_1(object sender, EventArgs e)
        {
            textBoxUsuario.CharacterCasing = CharacterCasing.Upper;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Model.Cadastro_UsuarioM musu = new Model.Cadastro_UsuarioM();
            Dao.Cadastra_UsuarioD dusu = new Dao.Cadastra_UsuarioD();
            Dao.LoginBD l = new Dao.LoginBD();

            if (textBoxID.Text != "" && textBoxUsuario.Text != "")
            {
                musu.SetId(textBoxID.Text);
                dusu.ExcluiUsuario(musu);
                MessageBox.Show("Usuario excluido com Sucesso !!!");
                textBoxID.Clear();
                textBoxUsuario.Clear();
                textBoxSenha.Clear();
                textBoxConfirmaSenha.Clear();

            }
        }

        private void frmCadastro_Usuario_Load(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxUsuario.Clear();
            textBoxSenha.Clear();
            textBoxConfirmaSenha.Clear();
        }
    }
}
