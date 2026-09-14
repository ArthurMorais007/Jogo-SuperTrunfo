using System;
using System.Collections.Generic;
using System.Linq;

namespace Jogo_SuperTrunfo
{
    public class Jogador
    {
        public string Nome { get; set; }
        public Queue<Carta> Mao { get; set; } = new Queue<Carta>();

        public Jogador(string nome)
        {
            Nome = nome;
        }
    }

    public class Partida
    {
        public List<Jogador> Jogadores { get; set; }
        public List<Carta> Baralho { get; set; }
        private List<Carta> monteAcumulado = new List<Carta>(); 

        public Partida(List<Jogador> jogadores, List<Carta> baralho)
        {
            Jogadores = jogadores;
            Baralho = baralho;
        }

        public void DistribuirCartas()
        {
            Random rng = new Random();
            var baralhoEmbaralhado = Baralho.OrderBy(c => rng.Next()).ToList();

            int indexJogador = 0;
            foreach (var carta in baralhoEmbaralhado)
            {
                Jogadores[indexJogador].Mao.Enqueue(carta);
                indexJogador = (indexJogador + 1) % Jogadores.Count;
            }

            Console.WriteLine("Cartas distribuídas entre os Mestres.");
        }

        public void ExecutarTurnoCombate(Jogador jogadorDaVez, int escolhaAtributo)
        {
            (string atributoEscolhido, string nomeAtributoFormatado) = ObterAtributoPorNumero(escolhaAtributo);

            Console.WriteLine($"--- O COMBATE IRÁ COMEÇAR! ATRIBUTO ESCOLHIDO: {nomeAtributoFormatado.ToUpper()} ---");
            if (monteAcumulado.Count > 0)
            {
                Console.WriteLine($"[MONTE ACUMULADO NA MESA: {monteAcumulado.Count} carta(s) de empates anteriores!]\n");
            }

            List<Carta> cartasNaMesa = new List<Carta>();

  
            foreach (var cartaMonte in monteAcumulado)
            {
                cartasNaMesa.Add(cartaMonte);
            }
            monteAcumulado.Clear();

            Dictionary<Jogador, int> valoresJogadores = new Dictionary<Jogador, int>();
            Dictionary<Jogador, Carta> cartasJogadores = new Dictionary<Jogador, Carta>();
            bool superTrunfoNaMesa = false;
            Jogador jogadorSuperTrunfo = null;

            foreach (var jogador in Jogadores.Where(j => j.Mao.Count > 0))
            {
                Carta cartaJogada = jogador.Mao.Dequeue();
                cartasNaMesa.Add(cartaJogada);
                cartasJogadores[jogador] = cartaJogada;

                int valorAtributoCarta = PegarValorAtributo(cartaJogada, atributoEscolhido);
                valoresJogadores[jogador] = valorAtributoCarta;

                Console.WriteLine($"{jogador.Nome} jogou: {cartaJogada.Nome} | {nomeAtributoFormatado}: {valorAtributoCarta}");

                if (cartaJogada.EhSuperTrunfo)
                {
                    superTrunfoNaMesa = true;
                    jogadorSuperTrunfo = jogador;
                }
            }

            if (superTrunfoNaMesa)
            {
                Console.WriteLine($"\n>> SUPER TRUNFO NA MESA! O Mestre {jogadorSuperTrunfo.Nome} venceu a rodada com {cartasJogadores[jogadorSuperTrunfo].Nome}! <<");
                foreach (var carta in cartasNaMesa)
                {
                    jogadorSuperTrunfo.Mao.Enqueue(carta);
                }
                return;
            }

            int maiorValor = valoresJogadores.Values.Max();


            var candidatosVencedores = valoresJogadores.Where(v => v.Value == maiorValor).Select(v => v.Key).ToList();

            if (candidatosVencedores.Count == 1)
            {
                Jogador vencedor = candidatosVencedores[0];
                Carta cartaVencedora = cartasJogadores[vencedor];

                Console.WriteLine($"\n>> VENCEDOR DA RODADA: {vencedor.Nome} com {cartaVencedora.Nome} (Valor: {maiorValor})! <<");
                if (cartasNaMesa.Count > cartasJogadores.Count)
                {
                    Console.WriteLine($"(Levou também o monte acumulado de empates anteriores!)");
                }

                foreach (var carta in cartasNaMesa)
                {
                    vencedor.Mao.Enqueue(carta);
                }
            }
            else
            {
            
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n>> EMPATE NO MAIOR VALOR! Ninguém leva as cartas nesta rodada. <<");
                Console.WriteLine("As cartas da mesa foram guardadas para a próxima rodada!");
                Console.ResetColor();

            
                foreach (var carta in cartasNaMesa)
                {
                    monteAcumulado.Add(carta);
                }
            }
        }

        private (string, string) ObterAtributoPorNumero(int escolha)
        {
            return escolha switch
            {
                1 => ("forca", "Força"),
                2 => ("velocidade", "Velocidade"),
                3 => ("resistencia", "Resistência"),
                4 => ("mana", "Mana"),
                5 => ("inteligencia", "Inteligência"),
                6 => ("noblephantasm", "Noble Phantasm"),
                _ => ("forca", "Força")
            };
        }

        private int PegarValorAtributo(Carta carta, string atributo)
        {
            return atributo.ToLower() switch
            {
                "forca" => carta.Forca,
                "velocidade" => carta.Velocidade,
                "resistencia" => carta.Resistencia,
                "mana" => carta.Mana,
                "inteligencia" => carta.Inteligencia,
                "noblephantasm" => carta.NoblePhantasm,
                _ => 0
            };
        }
    }
}