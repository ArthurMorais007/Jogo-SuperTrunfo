using System.Collections.Generic;

namespace JogoSuperTrunfo
{
    public class Baralho
    {
        public static List<Personagem> CriarBaralho()
        {
            return new List<Personagem>()
            {
                new Personagem("1A", "Illyana", "Maga", 90, 70, 100, 100,true),
                new Personagem("1B", "Arqueiro", "Archer", 70, 90, 10, 70, false)
            };
        }
    }
}

/