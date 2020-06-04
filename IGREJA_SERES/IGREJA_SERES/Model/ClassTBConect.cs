using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace IGREJA_SERES
{
    public class ClassTBConect
    {
        
        string conecta = "SERVER=localhost; DATABASE=capelania; UID=root; PWD=1234";
        protected MySqlConnection conexao = null;
       
        
        //metodo para conectar no banco
        public void AbrirConexao()
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                conexao.Open();
        
            }
            catch(Exception erro)
            {
                throw erro;
            }
          
        }
        //metodo para fechar conexão com banco
        public void FecharConexao()
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                conexao.Close();
            }
            catch(Exception erro)
            {
                throw erro;

            }
           
        }
    }
}
