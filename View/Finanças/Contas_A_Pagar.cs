﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.View.Finanças
{
    public partial class Contas_A_Pagar : Form
    {
        public Contas_A_Pagar()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmGridContas_A_Pagar gp = new frmGridContas_A_Pagar();
            gp.Show();
        }
    }
}
