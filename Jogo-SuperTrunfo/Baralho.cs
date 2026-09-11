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
                    "Classe: SABER",
                    "001",
                    95, 90, 95, 90, 85, 100,
                    "Eu sou o rei. Eu serei o seu rei.",
                    false
                ),
                new Personagem(
                    "Emiya",
                    "Classe: ARCHER",
                    "002",
                    85, 90, 80, 80, 90, 95,
                    "I am the bone of my sword.",
                    false
                ),
                new Personagem(
                    "Heracles",
                    "Classe: BERSERKER",
                    "003",
                    100, 70, 95, 60, 60, 100,
                    "Serei derrotado apenas por mim mesmo.",
                    false
                ),
                new Personagem(
                    "MedusA",
                    "Classe: Rider",
                    "003",
                    70, 80, 75, 70, 80, 85,
                    "Bellerophon",
                    false
                )
            };
        }
    }
}


