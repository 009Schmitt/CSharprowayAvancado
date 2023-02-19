using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmBuscaDaHeranca
{
    internal class Hero : DadosBase
    {
        public List<string> Inventario { get; set; }
        public string Arma { get; set; }
    }
}
