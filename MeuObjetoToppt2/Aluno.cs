using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuObjetoToppt2
{
    internal class Aluno
    {
        public string nome;
        public double nota1, nota2, nota3;

        public Aluno(string nome, double nota1, double nota2, double nota3)
        {
            this.nome = nome;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }

        public double CalculaMedia()
        {
            return (nota1 + nota2 + nota3) / 3;
        }
    }
}
