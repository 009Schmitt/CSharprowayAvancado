using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MeuPolimorfismoFofinho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lista 01            
            // 1) Crie uma classe chamada Ingresso que possui um valor em reais e um método ImprimeValor().

            //a) crie uma classe VIP, que herda Ingresso e possui um valor adicional. So-breescreva um método que retorne o valor do ingresso VIP (com o adicional in-cluído).

            //b) crie uma classe Normal, que herda Ingresso e possui um método que imprime: "Ingresso Normal"

            //c) crie uma classe CamaroteInferior (que possui a localização do ingresso e possui valor adicional) e uma classe CamaroteSuperior (que possui a localização do ingres-so e possui valor adicional equivalente a 3x o Camaroteinferior). ambas So-breescrevem o método para retornar o valor do ingresso. Ambas as classes herdam a classe VIP.

            //e) Simule um cliente comprando um ingresso, para isso, mostre todas as possi-bilidades e pergunte qual deseja comprar, após comprar, agradeça pela preferencia e encerre o programa.

            //Normal ingressoNormal = new Normal();

            //ingressoNormal.Valor = 40;

            //CamaroteInferior cInf = new CamaroteInferior();
            //cInf.LocalizacaoIngresso = "B19";
            //cInf.Valor = ingressoNormal.Valor;
            //cInf.Adicional = 60;

            //CamaroteSuperior cSup = new CamaroteSuperior();
            //cSup.localizacaoIngresso = "A11";
            //cSup.Valor = ingressoNormal.Valor;
            //cSup.Adicional = cInf.Adicional * 3;

            //ingressoNormal.ImprimeValor();
            //Console.WriteLine("-------------//--------------");
            //cInf.ImprimeValor();
            //Console.WriteLine("-------------//--------------");
            //cSup.ImprimeValor();
            //Console.WriteLine("-------------//--------------");
            //Console.WriteLine("Qual deseja comprar?");

            //exec 02
            //2) Implemente a classe Funcionario com nome, salario e ExibeDados().

            //a) crie a classe Assistente, que também é um funcionário, e que possui um número de matrícula. Sobrescreva o método ExibeDados().

            //b) sabendo que os Assistentes Técnicos possuem um bônus salarial e que os Assist - entes Administrativos possuem um turno(dia ou noite) e um adicional noturno, crie as classes Tecnico e Administrativo

            //c) agora que temos todos os possiveis cargos criados, crie um objeto de cada, preen-cha todos e então, imagine que o Dono irá usar o sistema com o seguinte menu:
            //1 - Adicionar : Peça os dados e insira
            //2 - Alterar : Mostre todos os funcionários, peça para o gerente quem deseja alterar e então as informações novas
            //3 - Excluir : Simplismente mostre todos na tela, então delete o escolhido
            //4 - Sair : Feche o programa

            //List<Tecnico> tecnicos = new List<Tecnico>();
            //List<Administrativo> adm = new List<Administrativo>();

            //while (true)
            //{
            //    /*Program.*/
            //    Menu();
            //    int escolha = Convert.ToInt32(Console.ReadLine());
            //    if (escolha == 1)
            //    {
            //        Console.WriteLine("1- Tecnico\n2- Administrativo");
            //        // vou reciclar a variavel escolha
            //        escolha = Convert.ToInt32(Console.ReadLine());

            //        if(escolha == 1)
            //        {
            //            Mostra(tecnicos);
            //            Console.WriteLine("Dados do Funcionario:");
            //            Tecnico temp = new Tecnico();
            //            Console.WriteLine("Nome");
            //            temp.Nome = Console.ReadLine();
            //            Console.WriteLine("Salario");
            //            temp.Salario = Convert.ToDouble(Console.ReadLine());
            //            Console.WriteLine("Numero de Matrícula");
            //            temp.NumeroMatricula = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("Bônus Salarial");
            //            temp.BonusSalario = Convert.ToDouble(Console.ReadLine());
            //            tecnicos.Add(temp);                       
            //        }
            //        else
            //        {
            //            Mostra(adm);
            //            Console.WriteLine("Dados do Funcionario:");
            //            Administrativo temp = new Administrativo();
            //            Console.WriteLine("Nome");
            //            temp.Nome = Console.ReadLine();
            //            Console.WriteLine("Salario");
            //            temp.Salario = Convert.ToDouble(Console.ReadLine());
            //            Console.WriteLine("Numero de Matrícula");
            //            temp.NumeroMatricula = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("Funcionário trabalha a noite?\ns-sim\nn-não");
            //            string noturno = Console.ReadLine();
            //            if(noturno.ToLower() == "s")
            //            {
            //                temp.TrabalhaNoturno = true;
            //                Console.WriteLine("qual o adicional noturno");
            //                temp.AdicionalNoturno = Convert.ToDouble(Console.ReadLine());
            //            }
            //            else
            //            {
            //                temp.TrabalhaNoturno = false;
            //                temp.AdicionalNoturno = 0;
            //            }
            //            adm.Add(temp);
            //        }

            //        Console.WriteLine("Funcionario adicionado com sucesso!");
            //    }
            //    else if (escolha == 2)
            //    {
            //        escolha = EscolhaUsuario();
            //        if(escolha == 1)
            //        {
            //            Mostra(tecnicos);
            //            escolha = Convert.ToInt32(Console.ReadLine());
            //            escolha--;
            //            Console.WriteLine("Nome");
            //            tecnicos[escolha].Nome = Console.ReadLine();
            //            Console.WriteLine("Salario");
            //            tecnicos[escolha].Salario = Convert.ToDouble(Console.ReadLine());
            //            Console.WriteLine("NumeroMatricula");
            //            tecnicos[escolha].NumeroMatricula = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("Bonus Salarial");
            //            tecnicos[escolha].BonusSalario = Convert.ToDouble(Console.ReadLine());

            //        }
            //        else
            //        {
            //            Mostra(adm);
            //            escolha = Convert.ToInt32(Console.ReadLine());
            //            escolha--;
            //            Console.WriteLine("Nome");
            //            adm[escolha].Nome = Console.ReadLine();
            //            Console.WriteLine("Salario");
            //            adm[escolha].Salario = Convert.ToDouble(Console.ReadLine());
            //            Console.WriteLine("NumeroMatricula");
            //            adm[escolha].NumeroMatricula = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("Funcionário tem Expediente Noturno?\ns-sim\nn-não");
            //            string temp = Console.ReadLine();
            //            if (temp.ToLower() == "s")
            //            {
            //                adm[escolha].TrabalhaNoturno = true;
            //                Console.WriteLine("Adicional Noturno");
            //                adm[escolha].AdicionalNoturno = Convert.ToDouble(Console.ReadLine());
            //            }
            //            else
            //            {
            //                adm[escolha].TrabalhaNoturno = false;
            //                adm[escolha].AdicionalNoturno = 0;
            //            }
            //        }
            //        Console.WriteLine("Funcionario alterado com sucesso!");

            //    }
            //    else if (escolha == 3)
            //    {
            //        escolha = EscolhaUsuario();

            //        if (escolha == 1)
            //        {
            //            Mostra(tecnicos);
            //            Console.WriteLine("Qual deseja excluir?");
            //            escolha = Convert.ToInt32(Console.ReadLine());
            //            tecnicos.RemoveAt(escolha - 1);
            //        }
            //        else
            //        {
            //            Mostra(adm);
            //            Console.WriteLine("Qual deseja excluir?");
            //            escolha = Convert.ToInt32(Console.ReadLine());
            //            adm.RemoveAt(escolha - 1);
            //        }
            //        Console.WriteLine("Funcionario excluído com sucesso!");
            //    }
            //    else if (escolha == 4)
            //    {
            //        Console.WriteLine("Obrigado por usar nosso sistema de RH");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Opçãum invalída");
            //    }

            //    Console.WriteLine("Aperte enter para continuar");
            //    Console.ReadKey();
            //    Console.Clear();
            //}

            //3) Crie a classe Imovel, que possui endereço, preço e CalculaValor()

            //a) crie uma classe Novo com precoAdiconal e herda Imovel.Sobreescreva o método CalculaValor() para computar o valor adicional

            //b) crie uma classe Velho, com desconto e herda Imovel . Sobreescreva o método CalculaValor() para computar o valor com desconto

            //c) crie um Cliente que possui nome e dinheiroDisponivel, em seguida, mostre 2 Imoveis Novos e 2 Velhos, então, pergunte qual o Cliente deseja comprar, caso nao possua dinheiro para aquela compra, sugira parcelar em 12x com 16,74 % de acréscimo ou escolher outro imóvel, caso possua agradeça pela preferência, se em algum momento o cliente fechou negócio, desconte aquele valor do dinheiroDis - ponivel(caso for parcelado, desconte apenas o valor de uma parcela)

            //OBS: para parcelar, primeiro incremente o valor do imovel baseado no acréscimo e em seguida, divada em 12 e terás o valor de cada parcela com acréscimo de 16,74 %

            Novo coberturaNaLapa = new Novo()
            {
                Endereco = "R. Copacabana  n126",
                Preco = 890000,
                PrecoAdicional = 260000
            };
            Novo coberturaEmBC = new Novo()
            {
                Endereco = "R. Centro  n563",
                Preco = 1250000,
                PrecoAdicional = 350000
            };

            Velho puchadinho = new Velho()
            {
                Endereco = "R. Tribess  n761",
                Preco = 125000,
                Desconto = 25000
            };

            Velho casarao = new Velho()
            {
                Endereco = "R. XV Novembro  n1057",
                Preco = 265000,
                Desconto = 15000
            };

            Cliente cli = new Cliente()
            {
                Nome = "Sra. Margot",
                DinheiroDisponivel = new Random().Next(150000, 1800000)
            };
            Console.WriteLine($"A Sra. Margot possui {cli.DinheiroDisponivel:c} para investir em seu imovel");


            Console.WriteLine("1");
            MostraPreco(coberturaNaLapa);
            Console.WriteLine("2");
            MostraPreco(coberturaEmBC);
            Console.WriteLine("3");
            MostraPreco(puchadinho);
            Console.WriteLine("4");
            MostraPreco(casarao);

            int escolha = Convert.ToInt32(Console.ReadLine());

            double preco = 0;
            switch (escolha)
            {
                case 1:
                    preco = coberturaNaLapa.Preco;
                    break;
                case 2:
                    preco = coberturaEmBC.Preco;
                    break;
                case 3:
                    preco = puchadinho.Preco;
                    break;
                case 4:
                    preco = casarao.Preco;
                    break;
                default:
                    Console.WriteLine("Imóvel não identificado na base de dados");
                    break;
            }

            //16,74 %
            if (cli.DinheiroDisponivel >= preco)
            {
                Console.WriteLine("Agradeçemos a preferência");
            }
            else
            {
                preco *= 1.1674;
                Console.WriteLine($"Você pode comprar seu imóvel em 12 suaves prestações de {preco/12:c}");
            }


            #endregion

            // Nao fechar o console na cara
            Console.ReadLine();
        }

        public static void MostraPreco(Novo nv)
        {
            nv.CalculaValor();
            Console.WriteLine($"Imóvel situado em {nv.Endereco}\nTem um custo de {nv.Preco}");
        }
        public static void MostraPreco(Velho vl)
        {
            vl.CalculaValor();
            Console.WriteLine($"Imóvel situado em {vl.Endereco}\nTem um custo de {vl.Preco}");
        }

        public static void Menu()
        {
            Console.WriteLine("+--------------+");
            Console.WriteLine("| 1- Adicionar |");
            Console.WriteLine("| 2- Alterar   |");
            Console.WriteLine("| 3- Excluir   |");
            Console.WriteLine("| 4- Sair      |");
            Console.WriteLine("+--------------+");
        }

        /// <summary>
        /// Recebe uma lista de Tecnicos e Mostra na tela
        /// </summary>
        /// <param name="tecnicos"></param>
        public static void Mostra(List<Tecnico> tecnicos)
        {
            for (int i = 0; i < tecnicos.Count; i++)
            {
                Console.WriteLine(i + 1);
                tecnicos[i].ExibeDados();
                Console.WriteLine("<><><><><><><><><>");
            }
        }

        /// <summary>
        /// Recebe uma lista de Administradores e Mostra na tela
        /// </summary>
        /// <param name="adm"></param>
        public static void Mostra(List<Administrativo> adm)
        {
            for (int i = 0; i < adm.Count; i++)
            {
                Console.WriteLine(i + 1);
                adm[i].ExibeDados();
                Console.WriteLine("<><><><><><><><><>");
            }
        }

        public static int EscolhaUsuario()
        {
            Console.WriteLine("1- Tecnico\n2- Administrativo");
            // vou reciclar a variavel escolha
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
