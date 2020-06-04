using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGREJA_SERES.Model
{
    public class perfil
    {

        string descricao;
        int ID;
        public int Id
        {
            get { return ID; }
            set { ID = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }


    }
}
