using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuObjetoToppt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exec 07
            //Crie 4 alunos que possuem nome, nota1,nota2,nota3 e uma função que retorna a média. Peça para o usuario preencher o nome, nota1,nota2 e nota3 deste aluno, em seguida, diga a média do aluno e se passou (para passar basta ter uma média > 7)

            List<Aluno> alunos = new List<Aluno>();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Insira o nome do {i+1}° aluno");
                string nome = Console.ReadLine();

                Console.WriteLine("Insira a 1° Nota");
                double nota1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Insira a 2° Nota");
                double nota2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Insira a 3° Nota");
                double nota3 = Convert.ToDouble(Console.ReadLine());

                Aluno temp = new Aluno(nome, nota1, nota2, nota3);

                alunos.Add(temp);
            }

            foreach (var item in alunos)
            {
                if(item.CalculaMedia() > 7)
                {
                    Console.WriteLine($"Aluno Aprovado com média : {item.CalculaMedia():#.##}");
                }
                else
                {
                    Console.WriteLine($"Aluno Reprovado com média : {item.CalculaMedia():#.##}");
                }
            }


            //Para nao fechar na cara
            Console.ReadLine();
        }
    }
}
