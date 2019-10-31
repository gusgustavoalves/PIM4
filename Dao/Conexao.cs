using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace PIM.Dao
{
    public class Conexao
    {
        MySqlConnection conexao = new MySqlConnection();
        private string statusbd;

        public string Statusbd { get => statusbd; set => statusbd = value; }

        public void Conectar()
        {
            try
            {
                conexao.ConnectionString = @"server = 187.32.22.185; port = 6661; User Id = root; database = pim; password = 010101ADS";
                conexao.Open();
                //MessageBox.Show("Conectado com Sucesso !!!");
                //conexao.Close();
            }
            catch
            {
                MessageBox.Show("Erro de Conexao Com O Banco de Dados !!!!");
            }
        }

        public void Desconectar()
        {
            try
            {
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Erro de Fechamento de conexão com Banco de Dados !!!!");
            }
        }

        public bool Checkconection()
        {           
            if (conexao.State == ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Testeconection()
        {
            try
            {
                conexao.ConnectionString = @"server = 187.32.22.185; port = 6661; User Id = root; database = pim; password = 010101ADS";
                conexao.Open();
                MessageBox.Show("Conectado com Sucesso !!!");
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Erro de Conexao Com O Banco de Dados !!!!");
            }
        }
        public MySqlConnection Traz_Conexao()
        {
            return conexao;
        }
    }
}
