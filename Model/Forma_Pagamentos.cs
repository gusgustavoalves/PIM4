using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.Model
{
     class Forma_Pagamentos
    {
         string dinheiro;
         string credito;
         string boleto;


        public void SetDinheiro(string dinheiro)
        {
            this.dinheiro = dinheiro;
        }
        public string GetDinheiro()
        {
            return this.dinheiro;
        }

        public void SetCredito(string credito)
        {
            this.credito = credito;
        }
        public string GetCredito()
        {
            return this.credito;
        }

        public void SetBoleto(string boleto)
        {
            this.boleto = boleto;
        }
        public string GetBoleto()
        {
            return this.boleto;
        }
    }
}
