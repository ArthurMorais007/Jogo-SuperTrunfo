using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JogoSuperTrunfo
{
    public class Jogador
    {
        public string Nome { get; set; }
        public Queue<Personagem> Mao { get; set; } = new Queue<Personagem>();

        public Jogador(string nome)
        {
            Nome = nome;
        }
    }

    public class Partida
    {
        public List<Jogador> Jogadores { get; set; }
        public List<Personagem> Baralho { get; set; }

        public Partida(List<Jogador> jogadores, List<Personagem> baralho)
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

            Console.WriteLine("Cartas distribuídas entre os jogadores.");
        }

        public void IniciarPartida(string atributoEscolhido)
        {
            Console.WriteLine($"\n--- O COMBATE IRÁ COMEÇAR! ATRIBUTO: {atributoEscolhido.ToUpper()} ---");

            List<Personagem> cartasNaMesa = new List<Personagem>();
            Jogador vencedor = null;
            Personagem cartaVencedora = null;
            int maiorValor = -1;
            bool superTrunfoNaMesa = false;

            foreach (var jogador in Jogadores.Where(j => j.Mao.Count > 0))
            {
                Personagem cartaJogada = jogador.Mao.Dequeue();
                cartasNaMesa.Add(cartaJogada);

                Console.WriteLine($"{jogador.Nome} jogou: {cartaJogada.Nome}");

                if (cartaJogada.EhSuperTrunfo)
                {
                    superTrunfoNaMesa = true;
                    vencedor = jogador;
                    cartaVencedora = cartaJogada;
                }
                else if (!superTrunfoNaMesa)
                {
                    int valorAtributo = PegarValorAtributo(cartaJogada, atributoEscolhido);

                    if (valorAtributo > maiorValor)
                    {
                        maiorValor = valorAtributo;
                        vencedor = jogador;
                        cartaVencedora = cartaJogada;
                    }
                }
            }

            if (vencedor != null)
            {
                Console.WriteLine($"\n>> VENCEDOR DA RODADA: {vencedor.Nome} com {cartaVencedora.Nome}! <<");
                foreach (var carta in cartasNaMesa)
                {
                    vencedor.Mao.Enqueue(carta);
                }
            }
        }

        private int PegarValorAtributo(Personagem carta, string atributo)
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