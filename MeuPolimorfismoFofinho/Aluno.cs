using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPolimorfismoFofinho
{
    internal class Aluno
    {
        public string nome;
        public double nota1, nota2, nota3;

        public double CalculaMedia()
        {
            return (nota1 + nota2 + nota3) / 3;
        }

        public double CalculaMediaEPassou(out string texto)
        {
            if ((nota1 + nota2 + nota3) / 3 > 7)
            {
                texto = "Aluno Aprovado";
            }
            else
            {
                texto = "Aluno Reprovado";
            }
            return (nota1 + nota2 + nota3) / 3;
        }

    }
}
