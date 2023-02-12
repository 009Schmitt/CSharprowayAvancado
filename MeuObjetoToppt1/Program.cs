using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MeuObjetoToppt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lista 01
            ////Exec 06
            //// Crie 3 empregados com nome, salário e cpf. Peça para o usuario preencher todos os funcionários,se o salário do funcionário for menor que 1500 de um aumento de 20%, após tudo isso, mostre na tela os funcionarios na ordem de menor salário para maior.

            //List<Empregado> colaboradores = new List<Empregado>();

            //Console.WriteLine("Querido e lindo chefe, gostaria de solicitar aume... digo, solicitar os funcionarios");
            //Console.WriteLine("Insira o Nome, CPF e Salario");

            //for (int i = 0; i < 3; i++)
            //{
            //    Empregado temp = new Empregado();

            //    Console.WriteLine($"Insira o nome do {i+1}° funcionario");
            //    temp.nome = Console.ReadLine();

            //    Console.WriteLine($"Insira o CPF do {i+1}° funcionario");
            //    temp.cpf = Console.ReadLine();

            //    Console.WriteLine($"Insira o Salário do {i+1}° funcionario");
            //    temp.salario = Convert.ToDouble(Console.ReadLine());

            //    colaboradores.Add(temp);
            //}

            //for (int i = 0; i < colaboradores.Count; i++)
            //{
            //    if (colaboradores[i].salario < 1500)
            //    {
            //        colaboradores[i].salario *= 1.2; 
            //    }
            //}

            ////colaboradores.Sort();

            //for (int i = 0; i < colaboradores.Count; i++)
            //{
            //    for (int j = i; j > 0; j--)
            //    {
            //        if (colaboradores[j-1].salario > colaboradores[j].salario)
            //        {
            //            Empregado temp = colaboradores[j];
            //            colaboradores[j] = colaboradores[j - 1];
            //            colaboradores[j - 1] = temp;
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //}

            //Console.WriteLine("A Lista atualizada dos empregados é:");
            //foreach (var item in colaboradores)
            //{
            //    Console.WriteLine($@"Nome    : {item.nome}");
            //    Console.WriteLine($@"CPF     : {Convert.ToInt64(item.cpf):000\.000\.000\-00}");
            //    Console.WriteLine($@"Salario : {item.salario:c}");
            //    Console.WriteLine("--------------||-------------");
            //}



            //// Exec 07
            //// Crie 3 alunos que possuem nome, nota1,nota2,nota3 e uma função que retorna a média. Peça para o usuario preencher o nome, nota1,nota2 e nota3 deste aluno, em seguida, diga a média do aluno e se passou (para passar basta ter uma média > 7)

            //List<Aluno> alunos = new List<Aluno>();

            //Console.WriteLine("Insira os alunos da aula");

            //for (int i = 0; i < 1; i++)
            //{
            //    Aluno temp = new Aluno();

            //    Console.WriteLine($"Insira o nome do {i+1}° aluno");
            //    temp.nome = Console.ReadLine();

            //    Console.WriteLine($"Insira a 1° nota");
            //    temp.nota1 = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine($"Insira a 2° nota");
            //    temp.nota2 = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine($"Insira a 3° nota");
            //    temp.nota3 = Convert.ToDouble(Console.ReadLine());

            //    alunos.Add(temp);
            //}

            //foreach (var item in alunos)
            //{
            //    //Console.Write($"O aluno {item.nome} foi ");
            //    //if(item.CalculaMedia() >= 7)
            //    //{
            //    //    Console.WriteLine($"Aprovado ☺ com média {item.CalculaMedia():#.##}");
            //    //}
            //    //else
            //    //{
            //    //    Console.WriteLine($"Reprovado :c com média {item.CalculaMedia():#.##}");
            //    //}

            //    string mensagem = "";

            //    double media = item.CalculaMediaEPassou(out mensagem);

            //    Console.WriteLine($"{item.nome}, {media}, {mensagem}");
            //}

            #endregion

            #region Lista 02
            // Exec 02
            //Crie 5 produtos para um mercado com nome do produto, id e preço. Peça para o usuário preencher todos os produtos(nao pode ter produtos com o mesmo id), em seguida, crie um carrinho de compras virtual que PODE ter até 20 produtos , ao finalizar a compra deve-se dizer ao usuario o nome de todos os produtos comprados e some o valor final.

            Console.WriteLine("Olá Gerente que todos amam :c , insira os produtos ");
            List<Produto> produtosDoMercado = new List<Produto>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Insira o Nome e preço do produto");
                Produto temp = new Produto()
                {
                    ID = i,
                    nome = Console.ReadLine(),
                    preco = Convert.ToDouble(Console.ReadLine())
                };

                produtosDoMercado.Add(temp);
            }

            List<Produto> carrinho = new List<Produto>();
            Menus tela = new Menus();
            while (true)
            {
                int escolha = 0;
                tela.Principal();
                escolha = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (escolha == 1) // Adicionar item
                {
                    tela.AdicionaAoCarrinho(produtosDoMercado);
                    int itemSelecionado = Convert.ToInt32(Console.ReadLine());
                    itemSelecionado--;
                    //if (itemSelecionado >= 0 && itemSelecionado <= 4)
                    if (itemSelecionado < 0 || itemSelecionado > 4)
                    {
                        Console.WriteLine("Item não consta na lista");
                    }
                    else
                    {
                        Console.WriteLine("Item adicionado com sucesso");
                        carrinho.Add(produtosDoMercado[itemSelecionado]);
                    }
                }
                else if (escolha == 2) // Remover item
                {
                    tela.RemoveCarrinho(carrinho);
                    Console.WriteLine("Qual item será excluido?");
                    int itemSelecionado = Convert.ToInt32(Console.ReadLine());
                    itemSelecionado--;

                    if (itemSelecionado < 0 || itemSelecionado >= carrinho.Count)
                    {
                        Console.WriteLine("Item não consta na lista");
                    }
                    else
                    {
                        Console.WriteLine("Item removido com sucesso");
                        carrinho.RemoveAt(itemSelecionado);
                    }


                    //carrinho.Remove(carrinho[itemSelecionado]);
                }
                else if (escolha == 3) // Ver Carrinho
                {
                    tela.CarrinhoAtual(carrinho);
                    Console.WriteLine("\nAperte ENTER para proceguir");
                    Console.ReadLine();
                }
                else if (escolha == 4) // Finalizar Compra
                {
                    Console.WriteLine("Agradeço pela preferência");
                    break;
                }
                else // Opção inválida
                {
                    Console.WriteLine("Opçãum invalída");
                }
            }

            tela.CarrinhoAtual(carrinho);

            double somatorio = 0;
            foreach (var item in carrinho)
            {
                somatorio += item.preco;
            }

            Console.WriteLine($"Valor final é : {somatorio:c}");
            #endregion


            // para não fechar na cara
            Console.ReadLine();

        }
    }
}
