using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGREJA_SERES.Model
{
    public class igreja
    {
        string descricao, nomePastor, numero;
        int ID, idpresidio;
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
        public string NomePastor
        {
            get { return nomePastor; }
            set { nomePastor = value; }
        }
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public int Idpresidio
        {
            get { return idpresidio; }
            set { idpresidio = value; }
        }
    }
}
