using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuObjetoToppt2
{
    internal class Empregado
    {
        public string nome;
        public string cpf;
        public int idade;
        public double salario;
        public double fgts;
        public double inss;

        public Empregado(string nome, string cpf, int idade, double salario)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.idade = idade;
            this.salario = salario;
            fgts = 0.12 * salario;
            inss = 0.09 * salario;
        }
    }
}
