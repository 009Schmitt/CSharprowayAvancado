using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuObjetoToppt1
{
    internal class Menus
    {
        public void Principal()
        {
            Console.WriteLine("*-------------------*");
            Console.WriteLine("|1- Adicionar Item  |");
            Console.WriteLine("|2- Remover Item    |");
            Console.WriteLine("|3- Ver Carrinho    |");
            Console.WriteLine("|4- Finalizar Compra|");
            Console.WriteLine("*-------------------*");
        }

        public void CarrinhoAtual(List<Produto> carrinho)
        {
            Console.WriteLine("\nSeu Carrinho Atual é:");
            Console.WriteLine("ID --- Nome --- Preço");
            foreach (var item in carrinho)
            {
                Console.WriteLine($"{item.ID} --- {item.nome} --- {item.preco:c}");
            }
        }

        public void AdicionaAoCarrinho(List<Produto> mercado)
        {
            Console.WriteLine("Produtos:");
            Console.WriteLine("id | Nome   |   Preço");
            foreach (var item in mercado)
            {
                Console.WriteLine($"{item.ID+1} | {item.nome} | {item.preco}");
            }
            Console.WriteLine("Escolha usando o id");
        }

        public void RemoveCarrinho(List<Produto> carrinho)
        {
            Console.WriteLine("\nSeu Carrinho Atual é:");
            Console.WriteLine("indice - ID --- Nome --- Preço");
            int contador = 1;
            foreach (var item in carrinho)
            {
                Console.WriteLine($"{contador} - {item.ID} --- {item.nome} --- {item.preco:c}");
                contador++;
            }
        }




    }
}
