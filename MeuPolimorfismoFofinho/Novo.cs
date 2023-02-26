using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPolimorfismoFofinho
{
    internal class Novo : Imovel
    {
        public double PrecoAdicional { get; set; }

        public override void CalculaValor()
        {
            Preco += PrecoAdicional;
        }


    }
}
