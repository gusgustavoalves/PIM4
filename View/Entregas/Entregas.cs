using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM.View.Entregas;

namespace PIM.View
{
    public partial class frmEntregas : Form
    {
        public frmEntregas()
        {
            InitializeComponent();
        }

        private void btn_Sair_ENTREGAS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEntregas_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisarEntregas_Click(object sender, EventArgs e)
        {
            frmPesquisa_Entregas pent = new frmPesquisa_Entregas();
            pent.Show();
        }
    }
}
