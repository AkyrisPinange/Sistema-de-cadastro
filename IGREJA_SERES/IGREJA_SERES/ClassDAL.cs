using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace IGREJA_SERES
{
    class ClassDAL
    {
        // acesso ao banco de dados//
        string conectaBanco = "SERVER=localhost; DATABASE=capelania; UID=root; PWD=1234";
        MySqlConnection conexao = null;
        MySqlCommand Comando;

        // Conexão com o banco e comando para selcionar todas os campo da tabela presidios//
        public DataTable ExibirDados()
        {
            try
            {
                conexao = new MySqlConnection(conectaBanco);
                Comando = new MySqlCommand("SELECT * FROM usuario", conexao);
                
                MySqlDataAdapter da = new MySqlDataAdapter();
               da.SelectCommand = Comando;

                DataTable dt= new DataTable();
                
                da.Fill(dt);

                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
