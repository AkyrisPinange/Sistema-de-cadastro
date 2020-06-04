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
    
    class UsuarioDao : ClassTBConect
    {
        
        MySqlCommand Comando = null;

        public void Salvar(usuario usuario)
        {

            try
            {
                AbrirConexao();

                Comando = new MySqlCommand("INSERT INTO usuario ( Nome, Login, Senha, idperfil) VALUES  ( @Nome, @Login, @Senha, @idperfil);",conexao);

                Comando.Parameters.AddWithValue("@Nome", usuario.Nome);
                Comando.Parameters.AddWithValue("@Login", usuario.Login);
                Comando.Parameters.AddWithValue("@Senha", usuario.Senha);
                Comando.Parameters.AddWithValue("@idperfil", usuario.Idperfil);

                Comando.ExecuteNonQuery();


            }
            catch(Exception erro)
            {
                throw erro;

            }
            finally
            {
                FecharConexao();
            }
        }

        public DataTable listar()
        {
            try
            {
                AbrirConexao();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                Comando = new MySqlCommand("SELECT * FROM usuario ORDER BY Nome", conexao);

                da.SelectCommand = Comando;
                da.Fill(dt);

                return dt;
            }
            catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
       
        //Metodo para Editar os dados do usuario
        public void Editar (usuario usuario)
        {
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("UPDATE usuario SET Nome = @Nome, Login = @Login, Senha = @Senha, idperfil = @idperfil WHERE idusuario = @idusuario", conexao);

                Comando.Parameters.AddWithValue("@idusuario", usuario.IDusuario);
                Comando.Parameters.AddWithValue("@Nome", usuario.Nome);
                Comando.Parameters.AddWithValue("@Login", usuario.Login);
                Comando.Parameters.AddWithValue("@Senha", usuario.Senha);
                Comando.Parameters.AddWithValue("@idperfil", usuario.Idperfil);

                Comando.ExecuteNonQuery();
            }
            catch(Exception erro)
            {
                throw erro;

            }
            finally
            {
                FecharConexao();
            }
        //metodo excluir usuario
            
        
        
        }
        public void Excluir(usuario usuario)
        {
            try
            {
                AbrirConexao();

                Comando = new MySqlCommand("DELETE FROM usuario WHERE idusuario = @idusuario", conexao);

                Comando.Parameters.AddWithValue("@idusuario", usuario.IDusuario);

                Comando.BeginExecuteNonQuery();

            }
            catch(Exception erro)
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
