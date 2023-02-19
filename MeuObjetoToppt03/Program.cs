using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MeuObjetoToppt03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lista01
            //Exec 03
            //Crie uma Pessoa com nome,cpf e idade.Após isso mostre na tela e peça para o usuario se deseja alterar a Pessoa inserida.

            Console.WriteLine("Querido Usuário, espero que esteja tudo bem com você e sua família, desejo felicidade e prosperidade em sua vida, agora INSIRA PARA MIM uma pessoa grato :3");

            while (true)
            {
                Pessoa pes = new Pessoa();
                Console.WriteLine("Nome");
                pes.SetNome(Console.ReadLine());
                Console.WriteLine("CPF");
                pes.SetCpf(Console.ReadLine());
                Console.WriteLine("Idade");
                pes.SetIdade(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine($"Nome  -> {pes.GetNome()}");
                Console.WriteLine($"CPF   -> {pes.GetCpf()}");
                Console.WriteLine($"Idade -> {pes.GetIdade()}");

                Console.WriteLine("\nEsta pessoa esta devidamente inserida?\n1 - Sim\n2 - Não");
                if(Console.ReadLine() == "1")
                {
                    Console.WriteLine("Obrigado por usar nossos serviços");
                    Thread.Sleep(200);
                    Console.Write("Processando.");
                    for (int i = 0; i < 5; i++)
                    {
                        Thread.Sleep(200);
                        Console.Write(".");
                    }
                    break;
                }
                Console.Clear();
            }



            // Exec 04
            /*Crie um Cliente para consultório dentário com nome,cpf e consultas[].Peça para o usuario preencher o cliente, após isso, mostre na tela as informações
            obs: as consultas[] devem ser armazenar em string para poder registrar o que foi feito, pode-se ter até consultas[10] por cliente.
            */

            //Cliente cli = new Cliente();

            //Console.WriteLine("Querida Márcia Preencha o Cliente");
            //Console.WriteLine("Nome: ");
            //cli.SetNome(Console.ReadLine());
            //Console.WriteLine("CPF: ");
            //cli.SetCpf(Console.ReadLine());

            //string[] consultas = new string[10];

            //for (int i = 0; i < consultas.Length; i++)
            //{
            //    Console.WriteLine($"Insira a {i + 1}° consulta ou insira S para Sair");
            //    string temp = Console.ReadLine();
            //    if (temp.ToLower() == "s")
            //    {
            //        Console.WriteLine("Finalizando...");
            //        break;
            //    }
            //    consultas[i] = temp;
            //}
            //cli.SetConsultas(consultas);           

            //Console.WriteLine($"O nome do Cliente é {cli.GetNome()}");
            //Console.WriteLine($"O CPF do Cliente é {cli.GetCpf()}");
            //Console.WriteLine("Consultas: ");
            //foreach (var item in cli.GetConsultas())
            //{
            //    //if(item == "")
            //    if (string.IsNullOrEmpty(item))
            //    {
            //        break;
            //    }
            //    Console.WriteLine(item);
            //}



            #endregion

            // pra não fechar na cara
            Console.ReadLine();
        }
    }
}
