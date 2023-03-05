using MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Control
{
    public static class ControleCliente
    {

        public static string EfetuaLogin(string login,string senha)
        {
            Cliente cli = ClienteBD.SelectLogin(login);
            if(cli.ID == -1)
            {
                return "Login não encontrado na base de dados";
            }

            if(cli.Senha == senha)
            {
                return "login efetuado";
            }

            return "Senha incorreta";
        }





    }
}
