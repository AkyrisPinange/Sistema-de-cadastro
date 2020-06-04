using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using IGREJA_SERES.Model;
using System.Data;

namespace IGREJA_SERES.Dao
{
    public class perfilDao : ClassTBConect
    {
        MySqlCommand Comando = null;
        public DataTable CarregaCombo()
        {
            try
            {
                AbrirConexao();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                Comando = new MySqlCommand("SELECT idperfil_usuario, descricao FROM perfil_usuario", conexao);

                da.SelectCommand = Comando;
                da.Fill(dt);

                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
