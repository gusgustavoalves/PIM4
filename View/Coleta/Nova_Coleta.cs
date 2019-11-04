using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.View
{
    public partial class frm_Dados_Da_Coleta : Form
    {
        public frm_Dados_Da_Coleta()
        {
            InitializeComponent();
        }

        private void bunifuTextBox2_Data_Da_Coleta_TextChanged(object sender, EventArgs e)
        {
        }

        private void bunifuButton1_Sai_Da_Coleta_Click(object sender, EventArgs e)
        {


        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            // fazer um if para validar se o formulario foi preenchi, se sim show.messeger "deseja sair sem salvar?"
            // se não,  this.Close();
          this.Close();
        }
    }
}
