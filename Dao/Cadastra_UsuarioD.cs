using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM.Model;

namespace PIM.Dao
{
    public class Cadastra_UsuarioD
    {
        Conexao Con = new Conexao();
        Model.Cadastro_UsuarioM U = new Model.Cadastro_UsuarioM();
        LoginBD l = new LoginBD();
        private bool Usuario_Exists = false;

        public bool Validausuario(Cadastro_UsuarioM cad)
        {
            if (!Con.Checkconection())
            {
                Con.Conectar();
            }

            if (Con.Checkconection())
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM USUARIO WHERE USUARIO = @usuario", Con.Traz_Conexao());
                command.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = (cad.GetUsuario());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                //Verifica se há uma lina no banco com esse Usuário.
                if (table.Rows.Count > 0)
                {
                    Usuario_Exists = true;
                }

                Con.Desconectar();
            }

            return Usuario_Exists;
        }






        public void CadastraUsuario(Cadastro_UsuarioM cad)
        {
            if (!Con.Checkconection())
            {
                Con.Conectar();
            }
            if (Con.Checkconection())
            {
                
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("INSERT INTO USUARIO (USUARIO, SENHA) VALUES (@USUARIO, @SENHA)", Con.Traz_Conexao());
                command.Parameters.Add("@USUARIO", MySqlDbType.VarChar, 45).Value = cad.GetUsuario();
                command.Parameters.Add("@SENHA", MySqlDbType.VarChar, 45).Value = cad.GetSenha();
                command.ExecuteNonQuery();
                Con.Desconectar();

            }
        }

        public void ExcluiUsuario(Cadastro_UsuarioM cad)
        {
            if (!Con.Checkconection())
            {
                Con.Conectar();
            }
            if (Con.Checkconection())
            {                
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("DELETE FROM USUARIO WHERE CODUSUARIO= @ID", Con.Traz_Conexao());
                command.Parameters.Add("@ID", MySqlDbType.VarChar, 45).Value = cad.GetId();
                command.ExecuteNonQuery();
                Con.Desconectar();

            }
        }

        public void AlterarUsuario(Cadastro_UsuarioM cad)
        {
            if (!Con.Checkconection())
            {
                Con.Conectar();
            }
            if (Con.Checkconection())
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("UPDATE USUARIO SET SENHA = @SENHA WHERE (CODUSUARIO = @ID);", Con.Traz_Conexao());
                command.Parameters.Add("@SENHA", MySqlDbType.VarChar, 45).Value = cad.GetSenha();
                command.Parameters.Add("@ID", MySqlDbType.VarChar, 45).Value = cad.GetId();
                command.ExecuteNonQuery();
                Con.Desconectar();

            }
        }
    }
}
