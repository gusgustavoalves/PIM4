using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using PIM.Model;

namespace PIM.Dao
{
    public class Cadastra_Cliente
    {
        Dao.Conexao Con = new Dao.Conexao();
        private bool Cliente_Exists = false;


        public bool VerCliente(CadastroFuncionario cad)        //Verifica se CPF ja esta cadastrado no banco de dados
        {
            if (!Con.Checkconection())
            {
                Con.Conectar();
            }

            if (Con.Checkconection())
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM cliente WHERE CPF = @cpf", Con.Traz_Conexao());
                command.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = cad.GetCPF();
                adapter.SelectCommand = command;
                adapter.Fill(table);

                //Verifica se há uma lina no banco com esse Cliente"CPF".
                if (table.Rows.Count > 0)
                {
                    Cliente_Exists = true;
                }

                Con.Desconectar();
            }

            return Cliente_Exists;
        }

            public void CadastraCliente(CadastroFuncionario cad)
        {
            if (!Con.Checkconection())
            {
                Con.Conectar();
            }

            if (Con.Checkconection())
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("INSERT INTO cliente (NOME, CPF, END) VALUES (@nome, @cpf, @end)", Con.Traz_Conexao());
                command.Parameters.Add("@nome", MySqlDbType.VarChar, 80).Value = cad.GetNome();
                command.Parameters.Add("@cpf", MySqlDbType.VarChar, 11).Value = cad.GetCPF();
                command.Parameters.Add("@end", MySqlDbType.VarChar, 80).Value = cad.GetEnd();
                command.ExecuteNonQuery();

                Con.Desconectar();
            }

        }
    }
}
