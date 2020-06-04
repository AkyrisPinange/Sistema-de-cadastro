using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGREJA_SERES.Model
{
    public class presidio
    {


        int ID, idigreja_pre;
        string nome_UP,  telefone_UP, email_UP, cnpj_UP, diretor, telefone_diretor, email_diretor, chefe_SEG, telefone_chefe_SEG, email_chefe_SEG;

        public int Id
        {
            get { return ID; }
            set { ID = value; }
        }
        public int Idigreja_pre
        {
            get { return idigreja_pre; }
            set { idigreja_pre = value; }
        }
        public string Nome_up
        {
            get { return nome_UP; }
            set { nome_UP = value; }
        }

        public string Telefone_UP
        {
            get { return telefone_UP; }
            set { telefone_UP = value; }
        }

        public string Email_UP
        {
            get { return email_UP; }
            set { email_UP = value; }
        }
        public string Cnpj_UP
        {
            get { return cnpj_UP; }
            set { cnpj_UP = value; }
        }
        public string Diretor
        {
            get { return diretor; }
            set { diretor = value; }
        }
        public string Telefone_diretor
        {
            get { return telefone_UP ; }
            set { telefone_UP = value; }
        }
        public string Email_diretor
        {
            get { return email_diretor; }
            set { email_diretor = value; }
        }
        public string Chefe_SEG
        {
            get { return chefe_SEG; }
            set { chefe_SEG = value; }
        }
        public string Telefone_chefe_SEG
        {
            get { return telefone_chefe_SEG; }
            set { telefone_chefe_SEG = value; }
        }
        public string Email_chefe_SEG
        {
            get { return email_chefe_SEG; }
            set { email_chefe_SEG = value; }
        }





    }

}
