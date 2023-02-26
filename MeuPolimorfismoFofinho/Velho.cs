using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPolimorfismoFofinho
{
    internal class Velho : Imovel
    {
        public double Desconto { get; set; }

        public override void CalculaValor()
        {
            Preco -= Desconto;
        }
    }
}
