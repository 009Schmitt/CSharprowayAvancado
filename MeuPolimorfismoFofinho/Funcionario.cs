using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPolimorfismoFofinho
{
    internal class Funcionario
    {
        public string Nome{ get; set; }
        public double Salario { get; set; }

        public virtual void ExibeDados()
        {
            Console.WriteLine($"O nome é {Nome} com salário de {Salario:c}");
        }
    }
}
