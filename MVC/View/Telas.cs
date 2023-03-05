using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.View
{
    public static class Telas
    {
        public static void MostraLogin()
        {
            Console.WriteLine("Por favor, insira o Login e Senha");
        }

        public static void MostraNaTela(string texto)
        {
            Console.WriteLine(texto);
        }

        public static string RecebeString()
        {
            return Console.ReadLine();
        }
    }
}
