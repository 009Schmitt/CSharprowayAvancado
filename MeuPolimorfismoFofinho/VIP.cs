using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPolimorfismoFofinho
{
    internal class VIP : Ingresso
    {
        public double Adicional { get; set; }

        public override void ImprimeValor()
        {
            Console.WriteLine($"O Valor o Ingresso Vip é : {Valor + Adicional:c}");
        }

    }
}
