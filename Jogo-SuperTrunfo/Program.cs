using JogoSuperTrunfo;
using System;
using System.Collections.Generic;
using System.Text;
namespace JogoSuperTrunfo
{
    public class Personagem
    {
        public string Nome { get; set; }
        public string ClasseRPG { get; set; }
        public string Codigo { get; set; }
        public bool EhSuperTrunfo { get; set; }

        public int Forca { get; set; }
        public int Velocidade { get; set; }
        public int Resistencia { get; set; }
        public int Mana { get; set; }
        public int Inteligencia { get; set; }
        public int NoblePhantasm { get; set; }

        public string Frase { get; set; }

        public Personagem(string nome, string classeRpg, string codigo, int forca, int velocidade, int resistencia, int mana, int inteligencia, int noblePhantasm, string frase, bool ehSuperTrunfo = false)
        {
            Nome = nome;
            ClasseRPG = classeRpg;
            Codigo = codigo;
            Forca = forca;
            Velocidade = velocidade;
            Resistencia = resistencia;
            Mana = mana;
            Inteligencia = inteligencia;
            NoblePhantasm = noblePhantasm;
            Frase = frase;
            EhSuperTrunfo = ehSuperTrunfo;
        }

        public void ExibirCarta()
        {
            ConsoleColor corTema = EhSuperTrunfo ? ConsoleColor.Yellow : ConsoleColor.Cyan;

     
            Console.ForegroundColor = corTema;
            Console.WriteLine("┌──────────────────────────────────────────┐");
            Console.WriteLine($"│ {ClasseRPG.ToUpper(),-26} {Codigo,13} │");
            Console.WriteLine("├──────────────────────────────────────────┤");

        
            Console.ForegroundColor = corTema;
            Console.Write("│ ");

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            string textoNome = $"NOME: {Nome.ToUpper()}";
            Console.Write(textoNome.PadRight(40));

            Console.ResetColor();
            Console.ForegroundColor = corTema;
            Console.WriteLine(" │");

      
            Console.WriteLine("├──────────────────────────────────────────┤");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine($"│ FORÇA: {Forca,33} │");
            Console.WriteLine($"│ VELOCIDADE: {Velocidade,28} │");
            Console.WriteLine($"│ RESISTÊNCIA: {Resistencia,27} │");
            Console.WriteLine($"│ MANA: {Mana,34} │");
            Console.WriteLine($"│ INTELIGÊNCIA: {Inteligencia,26} │");
            Console.WriteLine($"│ NOBLE PHANTASM: {NoblePhantasm,24} │");

      
            Console.ForegroundColor = corTema;
            Console.WriteLine("├──────────────────────────────────────────┤");
            Console.ForegroundColor = ConsoleColor.Gray;

            string fraseFormatada = $"\"[{Frase}]\"";
            if (fraseFormatada.Length > 38)
            {
                fraseFormatada = fraseFormatada.Substring(0, 33) + "...]\"";
            }

            Console.WriteLine($"│ {fraseFormatada,-40} │");

            Console.ForegroundColor = corTema;
            Console.WriteLine("└──────────────────────────────────────────┘");
            Console.ResetColor();
        }
    }


namespace JogoSuperTrunfo
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;

                List<Personagem> cartas = Baralho.CriarBaralho();

                foreach (var carta in cartas)
                {
                    carta.ExibirCarta();
                    Console.WriteLine();
                }

                Console.ReadKey();
            }
        }
    }
}