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
    class PresidioBLL
    {
        PresidioDao PresidioDao = new PresidioDao();

        public void salvar(presidio presidio)
        {
            try
            {
                PresidioDao.Salvar(presidio);
            }
            catch (Exception erro)
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
                dt = PresidioDao.listar();

                return dt;

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        //metodo para editar dados usuario

        public void Editar(presidio presidio)
        {
            try
            {
                PresidioDao.Editar(presidio);

            }
            catch (Exception erro)
            {
                throw erro;
            }

        }

        //metodo para excluir
        public void Excluir(presidio presidio)
        {
            try
            {
                PresidioDao.Excluir(presidio);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
