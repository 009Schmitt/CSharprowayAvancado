using MVC.Control;
using MVC.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //File.AppendAllText(@"C:\BD\Cliente.txt", "\n2|Juca da esquina|17|67598878909|Meu38|Kabum");


            Telas.MostraLogin();
            string login = Telas.RecebeString();
            string senha = Telas.RecebeString();

            string resposta = ControleCliente.EfetuaLogin(login, senha);
            Telas.MostraNaTela(resposta);


            // para nao fechar na cara
            Console.ReadLine();
        }
    }
}
