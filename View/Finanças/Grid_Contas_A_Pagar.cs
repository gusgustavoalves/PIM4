using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM.View.Finanças;

namespace PIM.View.Finanças
{
    public partial class frmGridContas_A_Pagar : Form
    {
        public frmGridContas_A_Pagar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contas_A_Pagar cp = new Contas_A_Pagar();
            cp.Show();
        }
    }
}
