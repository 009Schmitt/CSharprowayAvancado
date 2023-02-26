using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPolimorfismoFofinho
{
    internal class Normal : Ingresso
    {
        public override void ImprimeValor()
        {
            Console.WriteLine("Ingresso Normal");
            base.ImprimeValor();
        }

    }
}
