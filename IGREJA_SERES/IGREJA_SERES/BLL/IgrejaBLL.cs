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
    class IgrejaBLL
    {
        igrejaDao IgrejaDao = new igrejaDao();
        public DataTable CarregaComboUP()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = IgrejaDao.CarregaComboUP();

                return dt;

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public void salvar(igreja igreja)
        {
            try
            {
                IgrejaDao.Salvar(igreja);
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }
        public DataTable listarPorUP( int idpresidio)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = IgrejaDao.listarPorUP(idpresidio);

                return dt;

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public DataTable listar()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = IgrejaDao.listar();

                return dt;

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public void Editar(igreja igreja)
        {
            try
            {
                IgrejaDao.Editar(igreja);

            }
            catch (Exception erro)
            {
                throw erro;
            }

        }
        public void Excluir(igreja igreja)
        {
            try
            {
                IgrejaDao.Excluir(igreja);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
