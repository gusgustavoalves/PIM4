using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.Model
{
    public class Cadastro_UsuarioM
    {
        private string usuario;
        private string senha;
        private string id;

        public string GetId()
        {
            return id;
        }

        public void SetId(string value)
        {
            id = value;
        }

        public void SetUsuario(string usuario)
        {
            this.usuario = usuario;
        }
        public string GetUsuario()
        {
            return this.usuario;
        }

        public void SetSenha(string senha)
        {
            this.senha = senha;
        }
        public string GetSenha()
        {
            return this.senha;
        }
    }
}
