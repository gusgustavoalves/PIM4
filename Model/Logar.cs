﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.Model
{
    public class Logar
    {
        private string usuario;
        private string senha;

        

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
