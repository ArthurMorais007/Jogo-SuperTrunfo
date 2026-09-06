using System;
using System.Collections.Generic;
using System.Collections.Generic;
namespace JogoSuperTrunfo
{
    public class Personagem
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string ClasseRPG { get; set; }
        public bool EhSuperTrunfo { get; set; }

        public int Forca { get; set; }
        public int Agilidade { get; set; }
        public int Magia { get; set; }
        public int Vida { get; set; }

        public Personagem(string codigo, string nome, string classeRpg, int forca, int agilidade, int magia, int vida, bool ehSuperTrunfo = false)
        {
            Codigo = codigo;
            Nome = nome;
            ClasseRPG = classeRpg;
            Forca = forca;
            Agilidade = agilidade;
            Magia = magia;
            Vida = vida;
            EhSuperTrunfo = ehSuperTrunfo;
        }

        public void ExibirCarta()
        {
            ConsoleColor corOriginal = Console.ForegroundColor;

            ConsoleColor corMoldura = EhSuperTrunfo ? ConsoleColor.Yellow : ConsoleColor.Cyan;
            Console.ForegroundColor = corMoldura;

            Console.WriteLine("┌────────────────────────────────────┐");
            Console.WriteLine($"│ CARTA [{Codigo,-3}] - {Nome.ToUpper(),-20} │");
            Console.WriteLine($"│ Classe: {ClasseRPG,-26} │");

            if (EhSuperTrunfo)
            {
                Console.WriteLine("│ ???  S U P E R   T R U N F O  ???  │");
            }

            Console.WriteLine("├────────────────────────────────────┤");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"│ 1. ?? Força     : {Forca,-16} │");
            Console.WriteLine($"│ 2. ?  Agilidade : {Agilidade,-16} │");
            Console.WriteLine($"│ 3. ?  Magia     : {Magia,-16} │");
            Console.WriteLine($"│ 4. ?? Vida (HP) : {Vida,-16} │");

            Console.ForegroundColor = corMoldura;
            Console.WriteLine("└────────────────────────────────────┘\n");

            Console.ForegroundColor = corOriginal;
        }
    }
}
namespace JogoSuperTrunfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Personagem> cartas = Baralho.CriarBaralho();

            cartas[0].ExibirCarta();
            cartas[1].ExibirCarta();
            Console.ReadKey();
        }
    }
}
