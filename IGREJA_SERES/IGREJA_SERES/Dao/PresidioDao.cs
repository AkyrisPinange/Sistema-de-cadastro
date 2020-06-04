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
    class PresidioDao : ClassTBConect
    {
        MySqlCommand Comando = null;

        public void Salvar(presidio presidio)
        {

            try
            {
                AbrirConexao();

                Comando = new MySqlCommand("INSERT INTO presidio ( nome_UP ,telefone_UP, email_UP, cnpj_UP, diretor, telefone_diretor, email_diretor, chefe_SEG , telefone_chefe_SEG, email_chefe_SEG)"
                    + " VALUES  ( @nome_UP, @telefone_UP, @email_UP, @cnpj_UP, @diretor, @telefone_diretor, @email_diretor, @chefe_SEG , @telefone_chefe_SEG, @email_chefe_SEG);", conexao);

                Comando.Parameters.AddWithValue("@nome_UP", presidio.Nome_up);
                Comando.Parameters.AddWithValue("@telefone_UP", presidio.Telefone_UP);
                Comando.Parameters.AddWithValue("@email_UP", presidio.Email_UP);
                Comando.Parameters.AddWithValue("@cnpj_UP", presidio.Cnpj_UP);
                Comando.Parameters.AddWithValue("@diretor", presidio.Diretor);
                Comando.Parameters.AddWithValue("@telefone_diretor", presidio.Telefone_diretor);
                Comando.Parameters.AddWithValue("@email_diretor", presidio.Email_diretor);
                Comando.Parameters.AddWithValue("@chefe_SEG", presidio.Chefe_SEG);
                Comando.Parameters.AddWithValue("@telefone_chefe_SEG", presidio.Telefone_chefe_SEG);
                Comando.Parameters.AddWithValue("@email_chefe_SEG", presidio.Email_chefe_SEG);
                

                Comando.ExecuteNonQuery();


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

        public DataTable listar()
        {
            try
            {
                AbrirConexao();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                Comando = new MySqlCommand("SELECT * FROM presidio ORDER BY nome_UP", conexao);

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

        //Metodo para Editar os dados do usuario
        public void Editar(presidio presidio)
        {
            try
            {
                AbrirConexao();

                Comando = new MySqlCommand("UPDATE presidio SET nome_UP =@nome_UP, telefone_UP = @telefone_UP, email_UP = @email_UP, cnpj_UP = @cnpj_UP, diretor = @diretor," +
                    "telefone_diretor = @telefone_diretor, email_diretor = @email_diretor, chefe_SEG = @chefe_SEG , telefone_chefe_SEG = @telefone_chefe_SEG, email_chefe_SEG = @email_chefe_SEG  WHERE ID = @ID", conexao);

                Comando.Parameters.AddWithValue("@ID", presidio.Id);
                Comando.Parameters.AddWithValue("@nome_UP", presidio.Nome_up);
                Comando.Parameters.AddWithValue("@telefone_UP", presidio.Telefone_UP);
                Comando.Parameters.AddWithValue("@email_UP", presidio.Email_UP);
                Comando.Parameters.AddWithValue("@cnpj_UP", presidio.Cnpj_UP);
                Comando.Parameters.AddWithValue("@diretor", presidio.Diretor);
                Comando.Parameters.AddWithValue("@telefone_diretor", presidio.Telefone_diretor);
                Comando.Parameters.AddWithValue("@email_diretor", presidio.Email_diretor);
                Comando.Parameters.AddWithValue("@chefe_SEG", presidio.Chefe_SEG);
                Comando.Parameters.AddWithValue("@telefone_chefe_SEG", presidio.Telefone_chefe_SEG);
                Comando.Parameters.AddWithValue("@email_chefe_SEG", presidio.Email_chefe_SEG);
                



                Comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;

            }
            finally
            {
                FecharConexao();
            }
            //metodo excluir usuario



        }
        public void Excluir(presidio presidio)
        {
            try
            {
                AbrirConexao();

                Comando = new MySqlCommand("DELETE FROM presidio WHERE ID = @ID", conexao);

                Comando.Parameters.AddWithValue("@ID", presidio.Id);

                Comando.BeginExecuteNonQuery();

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
