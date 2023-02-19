using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmBuscaDaHeranca
{
    internal class Guerreiro : Hero
    {
        // Bloqueio (reduz dano)
        public int QtdReducao { get; set; }

        // Escudada (se acertar, anula o proximo turno do oponente)
        public int ChanceAcertoEscudada { get; set; }
        public int CDEscudada { get; set; }

        // Golpe Duplo (Tenta um segundo ataque)
        public int ChanceAcertoGolpeDuplo { get; set; }
        public int CDGolpeDuplo { get; set; }  
    }
}
