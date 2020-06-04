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
    class perfilBLL
    {
        perfilDao perfilDao = new  perfilDao();
        public DataTable CarregaCombo()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = perfilDao.CarregaCombo();

                return dt;

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
