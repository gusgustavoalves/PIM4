using System;
using System.Windows.Forms;

namespace PIM.View.Finanças
{
    public partial class frmConta_A_Receber : Form
    {
        public frmConta_A_Receber()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void frmConta_A_Receber_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmGridContas_A_Receber gb = new frmGridContas_A_Receber();
            gb.Show();
        }
    }
}
