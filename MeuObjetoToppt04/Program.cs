using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuObjetoToppt04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lista01
            //Exec 1 abc
            /*1) Crie uma ClassePai chamado Endereco com os seguintes dados : rua, numero, cidade e estado. Vamos usar esse escript como classe pai nos proximos exercícios.

            a) Crie uma subClasse chamado Pessoa com nome, idade, cpf e herda Endereco. Em seguida preecnha essa Pessoa e mostre na tela.

            b) Crie uma subClasse chamado Empresa com nome,quantida de funcionarios e herda Endereco. Em seguida preecnha essa Empresa e mostre na tela.

            c) Crie uma subClasse chamado Habitacao com tipo de habitacao, nome do dono e herda Endereco. Em seguida preencha 4 habitações e mostre todas na tela.
            */

            //a
            Pessoa pes = new Pessoa();
            Console.WriteLine("Preencha a pessoa com sus dados pessoais");
            Console.WriteLine("Nome");
            pes.Nome = Console.ReadLine();
            Console.WriteLine("Cpf");
            pes.Cpf = Console.ReadLine();
            Console.WriteLine("Idade");
            pes.Idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rua");
            pes.Rua = Console.ReadLine();
            Console.WriteLine("Número");
            pes.Numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cidade");
            pes.Cidade = Console.ReadLine();

            Console.WriteLine($"Nome   : {pes.Nome}");
            Console.WriteLine($"Cpf    : {pes.Cpf}");
            Console.WriteLine($"Idade  : {pes.Idade}");
            Console.WriteLine($"Rua    : {pes.Rua}");
            Console.WriteLine($"Numero : {pes.Numero}");
            Console.WriteLine($"Cidade : {pes.Cidade}");


            #endregion

            //Apenas para não fechar na cara
            Console.ReadLine();
        }
    }
}
