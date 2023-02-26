using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPolimorfismoFofinho
{
    internal class Tecnico : Assistente
    {
        public double BonusSalario { get; set; }

        public override void ExibeDados()
        {
            base.ExibeDados();
            Console.WriteLine($"Bônus salarial é : {BonusSalario:c}");
        }
    }
}
