using System.Collections.Generic;

namespace JogoSuperTrunfo
{
    public class Baralho
    {
        public static List<Personagem> CriarBaralho()
        {
            return new List<Personagem>()
            {
                new Personagem(
                    "Artoria Pendragon",
                    "SABER",
                    "001",
                    95, 90, 95, 90, 85, 100,
                    "Eu sou o rei. Eu serei o seu rei.",
                    false
                ),
                new Personagem(
                    "Emiya",
                    "ARCHER",
                    "002",
                    85, 90, 80, 80, 90, 95,
                    "I am the bone of my sword.",
                    false
                )
            };
        }
    }
}


