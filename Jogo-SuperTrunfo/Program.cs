using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jogo_SuperTrunfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<Carta> baralho = Baralho.CriarCartas();

            List<Jogador> jogadores = new List<Jogador>();

            Console.WriteLine("==========================================");
            Console.WriteLine("    BEM-VINDO AO SUPER TRUNFO FATE!       ");
            Console.WriteLine("==========================================\n");

            Console.WriteLine("=== CADASTRO DOS 5 MESTRES ===");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Informe o nome do Mestre {i}: ");
                string nome = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nome))
                {
                    nome = $"Mestre {i}";
                }

                jogadores.Add(new Jogador(nome));
            }

            Partida partida = new Partida(jogadores, baralho);
            partida.DistribuirCartas();

            Console.WriteLine("\nTodas as cartas do Espírito Heroico foram distribuídas entre os Mestres!");
            Console.WriteLine("Pressione qualquer tecla para iniciar a Guerra do Graal...");
            Console.ReadKey();
            Console.Clear();

            int indiceJogadorDaVez = 0;

            while (jogadores.Count(j => j.Mao.Count > 0) > 1)
            {
                while (jogadores[indiceJogadorDaVez].Mao.Count == 0)
                {
                    indiceJogadorDaVez = (indiceJogadorDaVez + 1) % jogadores.Count;
                }

                Jogador jogadorDaVez = jogadores[indiceJogadorDaVez];

                Console.WriteLine($"=== TURNO DO MESTRE: {jogadorDaVez.Nome.ToUpper()} ===");
                Console.WriteLine($"Cartas na mão: {jogadorDaVez.Mao.Count}\n");

                Carta cartaAtual = jogadorDaVez.Mao.Peek();
                cartaAtual.ExibirCarta();

                Console.WriteLine($"\nMestre {jogadorDaVez.Nome}, escolha o atributo para o combate:");
                Console.WriteLine("1 - Força");
                Console.WriteLine("2 - Velocidade");
                Console.WriteLine("3 - Resistência");
                Console.WriteLine("4 - Mana");
                Console.WriteLine("5 - Inteligência");
                Console.WriteLine("6 - Noble Phantasm");
                Console.Write("Opção: ");

                string opcao = Console.ReadLine();

                Console.Clear();

                partida.IniciarPartida();

                indiceJogadorDaVez = (indiceJogadorDaVez + 1) % jogadores.Count;

                Console.WriteLine("\nPressione qualquer tecla para a próxima rodada...");
                Console.ReadKey();
                Console.Clear();
            }

            Jogador campeao = null;
            foreach (var j in jogadores)
            {
                if (j.Mao.Count > 0)
                {
                    campeao = j;
                    break;
                }
            }

            if (campeao != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n==================================================================");
                Console.WriteLine($"  PARABÉNS! O MESTRE {campeao.Nome.ToUpper()} VENCEU A GUERRA DO SANTO GRAAL!  ");
                Console.WriteLine("==================================================================");
                Console.ResetColor();

                Console.WriteLine($"\nO Santo Graal se manifesta diante de você, Mestre {campeao.Nome}...");
                Console.Write("Qual é o seu desejo ao Santo Graal? ");
                string desejo = Console.ReadLine();

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("==================================================================");
                Console.WriteLine($"  O SANTO GRAAL CONCEDEU O SEU DESEJO: ");
                Console.WriteLine($"  \"{desejo}\"");
                Console.WriteLine("==================================================================");
                Console.ResetColor();
                Console.WriteLine("\nObrigado por jogar a Guerra do Santo Graal! Pressione qualquer tecla para sair...");
                Console.ReadKey();
            }
        }
    }
}