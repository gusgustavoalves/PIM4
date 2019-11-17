using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.Model{
    public class Cadastro
    {
        private string Nome;
        private string CPF;
        private string End;
        private string tempcpf;
       


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
            if (ValidaCPF(CPF))
            {
                this.CPF = tempcpf;
                //MessageBox.Show("CPF Valido!!!");
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
        public bool ValidaCPF(string CPF)


        {
            int[] mult1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] mult2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf;
            string digito;
            int soma;
            int resto;



                CPF = CPF.Trim();
            if (CPF.Contains(".") || CPF.Contains(",") || CPF.Contains("-"))
            {
                if (CPF.Contains("."))
                {
                    CPF = CPF.Replace(".", "");
                }
                if (CPF.Contains("-"))
                {
                    CPF = CPF.Replace("-", "");
                }
                if (CPF.Contains(","))
                {
                    CPF = CPF.Replace(",", "");
                }
                
            }
            if (CPF.Length != 11)
            {
                return false;
            }

            if (CPF.Distinct().Count() == 1)
            {
                return false;
            }

            tempCpf = CPF.Substring(0, 9);
            soma = 0;

            for (int cont = 0; cont < 9; cont++)
            {
                soma += int.Parse(tempCpf[cont].ToString()) * mult1[cont];
            }

            resto = soma % 11;

            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;

            for (int cont = 0; cont < 10; cont++)
            {
                soma += int.Parse(tempCpf[cont].ToString()) * mult2[cont];
            }

            resto = soma % 11;

            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
                digito = digito + resto.ToString();
            }
            //MessageBox.Show(CPF);
            tempcpf = CPF;
            return CPF.EndsWith(digito);
            

        }


    }
}
