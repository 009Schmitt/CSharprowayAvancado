using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmBuscaDaHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Acorde Joeslei, Acorde!!!");
            Console.WriteLine("Não, não é apenas um sonho que você é o herdeiro do rei");
            Console.WriteLine("Está no seu destino comandar o Reino de Orlux");
            Console.WriteLine("Vá e aceite seu destino");

            Console.WriteLine();

            Console.WriteLine("Escolha sua classe:");
            Console.WriteLine("1 - Guerreiro");
            Console.WriteLine("2 - 'Em Desenvolvimento'");
            Console.WriteLine("3 - 'Em Desenvolvimento'");
            Console.ReadLine();
            Console.WriteLine("Parabéns, sua classe será guerreiro");

            Guerreiro joeslei = new Guerreiro()
            {
                VidaMaxima = 50,
                VidaAtual = 50,
                DanoMin = 6,
                DanoMax = 10,
                ChanceCritico = 10,
                Nome = "Joeslei",
                Inventario = new List<string>(),
                Arma = "Espada e Escudo",
                QtdReducao = 60,
                ChanceAcertoEscudada = 70,
                CDEscudada = 3,
                ChanceAcertoGolpeDuplo = 65,
                CDGolpeDuplo = 2
            };

            Goblin gb = new Goblin()
            {
                VidaMaxima = 16,
                VidaAtual = 16,
                DanoMin = 4,
                DanoMax = 6,
                ChanceCritico = 15,
                Nome = "GAAARRR",
                Raca = "Goblin",
                Recompensa = 200,
                ChanceEmboscada = 15
            };


            GameManager.Combate(joeslei, gb);


            //So pra nao fecha na Cara
            Console.ReadLine();
        }
    }
}
