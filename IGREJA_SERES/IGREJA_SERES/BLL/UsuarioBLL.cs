using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IGREJA_SERES.Model;
using IGREJA_SERES.Dao;
using System.Data;
namespace IGREJA_SERES.BLL
{
    public class UsuarioBLL
    {
        UsuarioDao UsuarioDao = new UsuarioDao();

        public void salvar(usuario usuario)
        {
            try
            {
                UsuarioDao.Salvar(usuario);
            }
            catch(Exception erro)
            {
                throw erro;
            }
       
        }
        //metodo para lsitar
        public DataTable listar()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = UsuarioDao.listar();

                return dt;

            }catch(Exception erro)
            {
                throw erro;
            }
        }
        //metodo para editar dados usuario

        public void Editar(usuario usuario)
        {
            try
            {
                UsuarioDao.Editar(usuario);
                
            }
            catch(Exception erro)
            {
                throw erro;
            }

        }
    
        //metodo para excluir
        public void Excluir (usuario usuario)
        {
            try
            {
                UsuarioDao.Excluir(usuario);
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }
    }

}
