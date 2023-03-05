using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Model
{
    public static class ClienteBD
    {
        public static Cliente SelectLogin(string login)
        {
            //@"C:\BD\Cliente.txt"
            string[] texto = File.ReadAllLines(@"C:\BD\Cliente.txt");
            
            //texto[0] = "";

            foreach (var item in texto)
            {
                string[] temp = item.Split('|');
                try
                {
                    Cliente cli = new Cliente()
                    {
                        ID = Convert.ToInt32(temp[0]),
                        Nome = temp[1],
                        Idade = Convert.ToInt32(temp[2]),
                        Cpf = temp[3],
                        Login = temp[4],
                        Senha = temp[5]
                    };

                    if (cli.Login == login)
                    {
                        return cli;
                    }
                }
                catch (Exception)
                {

                }

            }


            return new Cliente()
            {
                ID = -1
            };
        }


    }
}
