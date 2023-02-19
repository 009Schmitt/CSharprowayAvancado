using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmBuscaDaHeranca
{
    internal class DadosBase
    {
        public int VidaMaxima { get; set; }
        public int VidaAtual { get; set; }
        public int DanoMin { get; set; }
        public int DanoMax { get; set; }
        public int ChanceCritico { get; set; }
        public string Nome { get; set; }
    }
}
