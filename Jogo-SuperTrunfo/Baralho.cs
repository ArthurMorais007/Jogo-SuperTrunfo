using System.Collections.Generic;

namespace JogoSuperTrunfo
{
    public class Baralho
    {
        public static List<Personagem> CriarCartas()
        {
            List<Personagem> cartas = new List<Personagem>();

            cartas.Add(new Personagem("Artoria Pendragon", "SABER", "A1", 95, 90, 95, 90, 85, 100, "Eu sou o seu rei.", false));
            cartas.Add(new Personagem("Artoria (Alter)", "SABER", "A2", 100, 85, 95, 80, 75, 95, "É um mundo sem misericórdia.", false));
            cartas.Add(new Personagem("Nero Claudius", "SABER", "A3", 85, 80, 85, 90, 80, 95, "Tudo o que eu quero...", false));
            cartas.Add(new Personagem("Mordred", "SABER", "A4", 90, 85, 85, 75, 70, 90, "Eu sou o que eu quero ser!", false));

  
            cartas.Add(new Personagem("Okita Souji", "SABER", "B1", 85, 95, 75, 70, 80, 90, "Não importa o que aconteça...", false));
            cartas.Add(new Personagem("Emiya", "ARCHER", "B2", 85, 90, 80, 75, 85, 95, "Eu só quero salvar pessoas.", false));
            cartas.Add(new Personagem("Gilgamesh", "ARCHER", "B3", 95, 90, 85, 80, 95, 100, "Eu sou a sua lei.", false));
            cartas.Add(new Personagem("Ishtar", "ARCHER", "B4", 80, 90, 75, 85, 80, 95, "O que é um desejo?", false));


            cartas.Add(new Personagem("Nikola Tesla", "ARCHER", "C1", 80, 85, 75, 85, 80, 95, "A eletricidade me move.", false));
            cartas.Add(new Personagem("Cu Chulainn", "LANCER", "C2", 90, 95, 80, 75, 70, 96, "Meu nome é Cu Chulainn!", false));
            cartas.Add(new Personagem("Scathach", "LANCER", "C3", 85, 90, 80, 75, 80, 95, "Você ainda não está pronto.", false));
            cartas.Add(new Personagem("Diarmuid Ua Duibhne", "LANCER", "C4", 80, 90, 75, 70, 75, 85, "A lança é minha alma.", false));

   
            cartas.Add(new Personagem("Karna", "LANCER", "D1", 85, 90, 85, 75, 80, 95, "Eu sou o herói solar.", false));
            cartas.Add(new Personagem("Vlad III", "RIDER", "D2", 85, 80, 75, 75, 80, 95, "Eu não sou um monstro...", false));
            cartas.Add(new Personagem("Medusa", "RIDER", "D3", 70, 80, 75, 70, 80, 85, "Eu sou apenas uma peã.", false));
            cartas.Add(new Personagem("Iskandar", "RIDER", "D4", 95, 80, 90, 75, 85, 95, "O que é a vida, senão a jornada...", false));

     
            cartas.Add(new Personagem("Achilles", "RIDER", "E1", 85, 90, 80, 70, 75, 90, "A velocidade é minha aliada.", false));
            cartas.Add(new Personagem("Francis Drake", "RIDER", "E2", 75, 85, 75, 70, 80, 90, "O Mar é meu reino!", false));
            cartas.Add(new Personagem("Medea", "CASTER", "E3", 60, 65, 70, 90, 95, 85, "O amor é mais divertido.", false));
            cartas.Add(new Personagem("Gilles de Rais", "CASTER", "E4", 60, 70, 65, 75, 80, 85, "O mundo é meu tabuleiro.", false));

        
            cartas.Add(new Personagem("Merlin", "CASTER", "F1", 55, 65, 60, 95, 95, 90, "O futuro ainda não está escrito.", false));
            cartas.Add(new Personagem("Medea Lily", "CASTER", "F2", 55, 60, 65, 90, 85, 80, "Uma vez, eu também amei.", false));
            cartas.Add(new Personagem("Tamamo-no-Mae", "ASSASSIN", "F3", 65, 70, 60, 90, 85, 85, "A deusa das mil faces.", false));
            cartas.Add(new Personagem("Sasaki Kojirou", "ASSASSIN", "F4", 70, 95, 60, 65, 75, 85, "A espada não mente.", false));


            cartas.Add(new Personagem("Jack the Ripper", "ASSASSIN", "G2", 75, 90, 65, 60, 70, 100, "Eu não sou uma criança.", false));
            cartas.Add(new Personagem("Semiramis", "ASSASSIN", "G3", 75, 80, 70, 85, 85, 90, "O poder é um jogo.", false));
            cartas.Add(new Personagem("Heracles", "BERSERKER", "G4", 100, 70, 95, 60, 60, 100, "Serei derrotado apenas por mim.", false));


            cartas.Add(new Personagem("Lancelot", "BERSERKER", "H1", 90, 90, 85, 65, 70, 95, "Meu nome é Lancelot...", false));
            cartas.Add(new Personagem("Frankenstein", "BERSERKER", "H2", 75, 70, 80, 65, 75, 85, "Eu só quero ter um lugar.", false));
            cartas.Add(new Personagem("Spartacus", "BERSERKER", "H3", 85, 75, 90, 60, 65, 85, "Liberdade é o meu direito!", false));
            cartas.Add(new Personagem("Kiyohime", "BERSERKER", "H4", 70, 75, 65, 75, 70, 85, "Eu sempre estarei ao seu lado.", false));


            cartas.Add(new Personagem("Jeanne d'Arc", "RULER", "I1", 85, 85, 95, 80, 80, 100, "O Senhor é minha luz.", false));
            cartas.Add(new Personagem("Mash Kyrielight", "SHIELDER", "I2", 75, 75, 100, 70, 75, 95, "Eu serei o seu escudo!", false));
            cartas.Add(new Personagem("Shirou Emiya", "MASTER", "I3", 60, 65, 75, 80, 70, 85, "Trace, on!", false));

            cartas.Add(new Personagem("O Santo Graal", "ARTIFACT", "ST", 100, 100, 100, 100, 100, 100, "O Graal não concede desejos.", true));

            return cartas;
        }
    }
}