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
    public class igrejaDao : ClassTBConect
    {
        MySqlCommand Comando = null;
        public DataTable CarregaComboUP()
        {
            try
            {
                AbrirConexao();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                Comando = new MySqlCommand("SELECT ID, nome_UP FROM VW_presidio", conexao);

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


        public void Salvar(igreja igreja)
        {

            try
            {
                AbrirConexao();

                Comando = new MySqlCommand("INSERT INTO igreja ( descricao, NomePastor, Numero, idpresidio) VALUES  ( @descricao, @NomePastor, @Numero, @idpresidio);", conexao);

                Comando.Parameters.AddWithValue("@descricao", igreja.Descricao);
                Comando.Parameters.AddWithValue("@NomePastor", igreja.NomePastor);
                Comando.Parameters.AddWithValue("@Numero", igreja.Numero);
                Comando.Parameters.AddWithValue("@idpresidio", igreja.Idpresidio);


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
        public DataTable listarPorUP(int idpresidio)
        {
            try
            {
                AbrirConexao();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                Comando = new MySqlCommand("SELECT * FROM igreja WHERE idpresidio = @idpresidio", conexao);

                Comando.Parameters.AddWithValue("@idpresidio", idpresidio);


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


        public DataTable listar()
        {
            try
            {
                AbrirConexao();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                Comando = new MySqlCommand("SELECT * FROM igreja ORDER BY descricao", conexao);

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
        public void Editar(igreja igreja)
        {
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("UPDATE igreja SET descricao = @descricao, NomePastor = @NomePastor, Numero = @Numero, idpresidio = @idpresidio WHERE idigreja = @idigreja", conexao);

                Comando.Parameters.AddWithValue("@idigreja", igreja.Id);
                Comando.Parameters.AddWithValue("@descricao", igreja.Descricao);
                Comando.Parameters.AddWithValue("@NomePastor", igreja.NomePastor);
                Comando.Parameters.AddWithValue("@Numero", igreja.Numero);
                Comando.Parameters.AddWithValue("@idpresidio", igreja.Idpresidio);

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
        public void Excluir(igreja igreja)
        {
            try
            {
                AbrirConexao();

                Comando = new MySqlCommand("DELETE FROM igreja WHERE idigreja = @idigreja", conexao);

                Comando.Parameters.AddWithValue("@idigreja", igreja.Id);

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

