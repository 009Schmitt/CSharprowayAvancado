using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MeuPolimorfismoFofinho
{
    internal class Ingresso
    {
        public double Valor { get; set; }

        public virtual void ImprimeValor()
        {
            Console.WriteLine($"Valor do ingresso é : {Valor:c}");
        }

    }
}
