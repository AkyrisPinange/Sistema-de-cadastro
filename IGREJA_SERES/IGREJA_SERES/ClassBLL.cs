using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace IGREJA_SERES
{
    class ClassBLL
    {
        ClassDAL dal = null;

        public DataTable ExibirDadosDal()
        {
            try
            {
                DataTable DataT = new DataTable();
                dal = new ClassDAL();
                DataT = dal.ExibirDados();

                return DataT;
            }
            catch(Exception erro)
            {
                throw erro;
            }
            
        }
   
    }
}
