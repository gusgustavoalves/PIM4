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
    public partial class frmClienteFornecedores : Form
    {
        public frmClienteFornecedores()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisa_cliente_Fornecedores cli = new frmPesquisa_cliente_Fornecedores();
            cli.Show();
        }
    }
}
