using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho21_10_2019_1ponto.Model
{
    public class Logar
    {
        private string Usuario;
        private string Senha;

        public string GetUsuario()
        {
            return this.Usuario;
        }

        public void SetUsuario(string Usuario)
        {
            this.Usuario = Usuario;
        }

        public string GetSenha()
        {
            return this.Senha;
        }

        public void SetSenha(string Senha)
        {
            this.Senha = Senha;
        }
    }
}
