using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPolimorfismoFofinho
{
    internal class Administrativo : Assistente
    {
        public bool TrabalhaNoturno { get; set; }
        public double AdicionalNoturno { get; set; }

        public override void ExibeDados()
        {
            base.ExibeDados();
            if(TrabalhaNoturno)
            {
                Console.WriteLine("Funcionário do expediente Noturno");
                Console.WriteLine($"O Adicional noturno é : {AdicionalNoturno}");
            }
            else
            {
                Console.WriteLine("Funcionário não trabalha no expediente Noturno");
            }

        }

    }
}
