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
            Console.WriteLine("    BEM-VINDO AO FATE: NOBLE TRUNFO!       ");
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
            int rodadas = 0;
            const int MAX_RODADAS = 150;

            while (jogadores.Count(j => j.Mao.Count > 0) > 1 && rodadas < MAX_RODADAS)
            {
                rodadas++;

                while (jogadores[indiceJogadorDaVez].Mao.Count == 0)
                {
                    indiceJogadorDaVez = (indiceJogadorDaVez + 1) % jogadores.Count;
                }

                Jogador jogadorDaVez = jogadores[indiceJogadorDaVez];

                int escolhaAtributo = -1;

                while (escolhaAtributo < 1 || escolhaAtributo > 6)
                {
                    Console.Clear();
                    Console.WriteLine($"=== RODADA {rodadas}/{MAX_RODADAS} ===");
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

            if (rodadas >= MAX_RODADAS)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n==================================================================================");
                Console.WriteLine($"  ATENÇÃO: A GUERRA PROLONGOU-SE DEMAIS! LIMITE DE {MAX_RODADAS} RODADAS ATINGIDO.  ");
                Console.WriteLine("==================================================================================");
                Console.ResetColor();

                campeao = jogadores.OrderByDescending(j => j.Mao.Count).First();

                Console.WriteLine("\nPlacar final dos Mestres que sobreviveram:");
                foreach (var j in jogadores.Where(j => j.Mao.Count > 0))
                {
                    Console.WriteLine($"- Mestre {j.Nome}: {j.Mao.Count} cartas.");
                }
            }
            else
            {
                campeao = jogadores.FirstOrDefault(j => j.Mao.Count > 0);
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