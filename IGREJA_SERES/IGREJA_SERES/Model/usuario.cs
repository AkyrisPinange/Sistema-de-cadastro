using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGREJA_SERES.Model
{
    public class usuario
    {
        int Idusuario,  idperfil;
        string nome, login, senha;
        public int IDusuario
        {
            get { return Idusuario; }
            set { Idusuario = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        public int Idperfil
        {
            get { return idperfil; }
            set { idperfil = value; }
        }
    }
}
