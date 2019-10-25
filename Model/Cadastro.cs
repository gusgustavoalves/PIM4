using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho21_10_2019_1ponto.Model
{
    class Cadastro
    {
        private string TempCpf;
        private string Nome;
        private string CPF;
        private string End;
        

        public string GetTempCpf()
        {
            return this.TempCpf;
        }

        public void SetTempCpf(string TempCpf)
        {
            this.TempCpf = TempCpf;
        }

        public string GetNome()
        {
            return this.Nome;
        }

        public void SetNome(string Nome)
        {
            this.Nome = Nome;
        }

        public string GetCPF()
        {
            return this.CPF;
        }

        public void SetCPF(string CPF)
        {
            Model.CPF cpf = new Model.CPF();
            if (cpf.ValidaCPF(GetTempCpf()))
            {
                this.CPF = CPF;
                MessageBox.Show("CPF Valido!!!");
            }
            else
            {
                MessageBox.Show("CPF Invalido!!!");
            }



        }

        public string GetEnd()
        {
            return this.End;
        }


        public void SetEnd(string End)
        {
            this.End = End;
        }

        public void Cadastra_cliente()
        {
                     
        }

    }
}
