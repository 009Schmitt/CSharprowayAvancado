using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmBuscaDaHeranca
{
    internal static class GameManager
    {
        public static void Combate(Hero heroi, Inimigo inimigo)
        {
            Random rand = new Random();
            bool heroiComeca = true;
            string menu = "";

            // Inimigos
            Goblin gb = new Goblin();

            if (inimigo.GetType().ToString().Contains("Goblin"))
            {
                gb = inimigo as Goblin;
                if (rand.Next(1, 100 + 1) <= gb.ChanceEmboscada)
                {
                    Console.WriteLine("Fui Emboscado");
                    heroiComeca = false;
                }
            }

            // Herois
            Guerreiro g = new Guerreiro();

            if (heroi.GetType().ToString().Contains("Guerreiro"))
            {
                int cdTempEscudade = 0, cdTempGolpeDuplo = 0;
                g = heroi as Guerreiro;
                menu = "1-Atacar\n2-Defender\n3-Escudada\n4-Golpe Duplo\n5-Inventário";

                while (g.VidaAtual > 0 && inimigo.VidaAtual > 0)
                {
                    int defesa = 0;
                    // Se o heroi foi emboscado
                    if (!heroiComeca)
                    {
                        g.VidaAtual -= rand.Next(inimigo.DanoMin, inimigo.DanoMax + 1);
                        heroiComeca = true;
                    }
                    Console.WriteLine($"Vida Atual: {g.VidaAtual}");
                    Console.WriteLine($"Vida Do Inimigo: {inimigo.VidaAtual}");
                    Console.WriteLine(menu);
                    string escolha = Console.ReadLine();

                    if (escolha == "1")
                    {
                        int dano = rand.Next(g.DanoMin, g.DanoMax + 1);
                        if (rand.Next(1, 100 + 1) <= g.ChanceCritico)
                        {
                            Console.WriteLine("Dei Crítico");
                            dano *= 2;
                        }
                        Console.WriteLine(dano);
                        inimigo.VidaAtual -= dano;
                    }
                    else if (escolha == "2")
                    {
                        defesa = g.QtdReducao;
                    }

                    // Ataque Inimigo

                    int danoInimigo = rand.Next(inimigo.DanoMin, inimigo.DanoMax + 1);
                    if (rand.Next(1, 100 + 1) <= inimigo.ChanceCritico)
                    {
                        Console.WriteLine("Tomei Crítico");
                        danoInimigo *= 2;
                    }

                    danoInimigo = Convert.ToInt32(Math.Round(Convert.ToDouble(danoInimigo) * ((100 - defesa) / 100)));

                    Console.WriteLine(danoInimigo);

                    g.VidaAtual -= danoInimigo;

                }
                Console.WriteLine($"Vida Atual {g.VidaAtual}");


                if(g.VidaAtual > 0)
                {
                    Console.WriteLine("Joeslei Venceu");
                }
                else
                {
                    Console.WriteLine("Joeslei Foi Abatido");
                }
            }




            //Console.WriteLine(heroi.GetType().ToString());
            //Console.WriteLine(inimigo.GetType().ToString());

        }







    }
}
