using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaExcecaoFofinha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2) Crie um programa que recebe um numero(int) qualquer, se por acaso o numero for grande de mais avise “Numero gigantesco” caso tiver letras e afins, avise “Apenas numeros” e então, peça novamente até dar certo, quando der certo, avise “Deu certo”

            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Insira um número");
            //        int numero = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Deu Certo");
            //        break;
            //    }
            //    catch (OverflowException)
            //    {
            //        Console.WriteLine("Numero Gigantesco");
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Apenas numeros");
            //    }
            //}

            while (true)
            {
                try
                {
                    Console.WriteLine("Insira um número");
                    int numero = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Deu Certo");
                    break;
                }
                catch (Exception ex)
                {                    
                    if(ex.ToString().Contains("FormatException"))
                    {
                        Console.WriteLine("Apenas numeros");
                    }
                    else if (ex.ToString().Contains("OverflowException"))
                    {
                        Console.WriteLine("Numero Gigantesco");
                    }
                    else
                    {
                        Console.WriteLine("Erro inesperado");
                    }
                }
            }




            // so para nao fechar na cara
            Console.ReadLine();
        }
    }
}
