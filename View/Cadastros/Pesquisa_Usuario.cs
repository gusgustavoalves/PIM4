using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM.Dao;
using PIM;
using MySql.Data.MySqlClient;

namespace PIM.View.Cadastros
{
    public partial class frmPesquisa_Usuario : Form
    {
        public string Usuario { get; private set; }
        public string Senha { get; private set; }
        public int Id { get; private set; }

        public void listagridP()
        {
            
            Conexao Con = new Conexao();
            string usu = textBoxUsuario.Text;
            if (!Con.Checkconection())
            {
                Con.Conectar();
            }

            if (Con.Checkconection())
            {
                GVUsuario.DataSource = null;
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM USUARIO WHERE USUARIO = @usuario", Con.Traz_Conexao());
                command.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = (usu);
                adapter.SelectCommand = command;
                adapter.Fill(table);

                GVUsuario.DataSource = table;
                GVUsuario.Update();
                GVUsuario.Refresh();

                Con.Desconectar();
            }
        }

        public void listagridN()
        {

            Conexao Con = new Conexao();
            string usu = textBoxUsuario.Text;
            if (!Con.Checkconection())
            {
                Con.Conectar();
            }

            if (Con.Checkconection())
            {
                GVUsuario.DataSource = null;
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM USUARIO", Con.Traz_Conexao());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                GVUsuario.DataSource = table;
                GVUsuario.Update();
                GVUsuario.Refresh();

                Con.Desconectar();
            }
        }

        public frmPesquisa_Usuario()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GVUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Id = int.Parse(GVUsuario.CurrentRow.Cells[0].Value.ToString());
            this.Usuario = GVUsuario.CurrentRow.Cells[1].Value.ToString();
            this.Senha = GVUsuario.CurrentRow.Cells[2].Value.ToString();

            this.DialogResult = DialogResult.OK; // para indicar ao Form chamador que o usuário adicionou um cliente
            this.Close();
        }

        private void frmPesquisa_Usuario_Load(object sender, EventArgs e)
        {
            listagridN();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if(textBoxUsuario.Text == "")
            {
                listagridN();
            }
            else
            {
                listagridP();
            }
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            textBoxUsuario.CharacterCasing = CharacterCasing.Upper;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BntSelecionar_Click(object sender, EventArgs e)
        {
            this.Id = int.Parse(GVUsuario.CurrentRow.Cells[0].Value.ToString());
            this.Usuario = GVUsuario.CurrentRow.Cells[1].Value.ToString();
            this.Senha = GVUsuario.CurrentRow.Cells[2].Value.ToString();

            this.DialogResult = DialogResult.OK; // para indicar ao Form chamador que o usuário adicionou um cliente
            this.Close();
        }
    }
}
