using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Trabalho21_10_2019_1ponto.Model;

namespace Trabalho21_10_2019_1ponto.Dao
{
    public class LoginBD
    {
        Dao.Conexao Con = new Dao.Conexao();
        private bool User_Exists = false;

        public bool Validausuario(Logar Login)
        {
            if (!Con.Checkconection())
            {
                Con.Conectar();
            }

            if (Con.Checkconection())
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM usuario WHERE USUARIO = @usuario AND SENHA = @senha", Con.Traz_Conexao());

                command.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = Login.GetUsuario();
                command.Parameters.Add("@senha", MySqlDbType.VarChar).Value = Login.GetSenha();
                adapter.SelectCommand = command;
                adapter.Fill(table);

                //Verifica se há uma lina no banco com esse Usuário.
                if (table.Rows.Count > 0)
                {
                    User_Exists = true;
                }

                Con.Desconectar();
            }

            return User_Exists;
        }
    }
}
