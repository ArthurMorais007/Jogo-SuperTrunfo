# 🎴 Fate: Noble Trunfo

Um jogo de cartas inspirado no clássico **Super Trunfo**, desenvolvido em **C#** com temática baseada no universo de **Fate**.

No jogo, cinco Mestres disputam a **Guerra do Santo Graal** utilizando cartas de personagens e comparando seus atributos. O objetivo é conquistar as cartas dos adversários e se tornar o último Mestre com cartas em sua mão.

---

## 📖 Sobre o Projeto

O **Fate: Noble Trunfo** foi desenvolvido como um projeto acadêmico com o objetivo de aplicar conceitos de **Programação Orientada a Objetos**, estruturas de dados, lógica de programação e testes automatizados na criação de um jogo de cartas baseado no Super Trunfo.

O projeto apresenta personagens de diferentes classes do universo Fate, cada um possuindo atributos próprios que são utilizados durante os combates.

Além das cartas normais, existe uma carta especial, o **Santo Graal**, que funciona como o **Super Trunfo** do jogo.

---

## 🎮 Como Jogar

Ao iniciar o jogo, são cadastrados **5 Mestres**.

Cada jogador recebe uma quantidade de cartas após o baralho ser embaralhado e distribuído.

Em cada rodada:

1. O Mestre da vez visualiza sua carta.
2. O jogador escolhe um dos seis atributos disponíveis.
3. Cada Mestre revela a carta que está no topo de sua mão.
4. Os valores do atributo escolhido são comparados.
5. O jogador com o maior valor vence a rodada.
6. O vencedor recebe todas as cartas utilizadas no combate.
7. Em caso de empate, as cartas ficam acumuladas para a próxima rodada.

A partida continua até que apenas um jogador possua cartas.

---

## ⭐ Super Trunfo — Santo Graal

A carta especial do jogo é:

> **O Santo Graal**

Ela possui a propriedade `EhSuperTrunfo` ativada e possui **100 pontos em todos os atributos**.

Quando o Santo Graal aparece em uma rodada, o jogador que estiver com essa carta vence imediatamente o combate e recebe todas as cartas que estavam na mesa.

Isso faz com que o Santo Graal tenha uma função especial semelhante à carta **Super Trunfo** do jogo original.

---

## ⚔️ Classes dos Personagens

As cartas representam diferentes classes e personagens do universo Fate.

Entre as classes presentes no jogo estão:

* ⚔️ **Saber**
* 🏹 **Archer**
* 🔮 **Caster**
* 🏇 **Rider**
* 🗡️ **Lancer**
* 🥷 **Assassin**
* 💪 **Berserker**
* 👑 **Ruler**
* 🛡️ **Shielder**
* 👤 **Master**
* 🏆 **Artifact**

---

## 📊 Atributos

Cada carta possui seis atributos utilizados nos combates:

| Atributo          | Descrição                                         |
| ----------------- | ------------------------------------------------- |
| 💪 Força          | Representa a força física do personagem           |
| ⚡ Velocidade      | Representa a velocidade e agilidade               |
| 🛡️ Resistência   | Representa a capacidade de resistência            |
| 🔮 Mana           | Representa o poder mágico                         |
| 🧠 Inteligência   | Representa a capacidade intelectual e estratégica |
| 💥 Noble Phantasm | Representa o poder do Fantasma Nobre              |

Cada atributo possui valores que podem variar de acordo com o personagem.

---

## ⚔️ Sistema de Combate

O sistema de combate é responsável por comparar os atributos das cartas jogadas pelos Mestres.

O jogador da vez escolhe entre:

```text
1 - Força
2 - Velocidade
3 - Resistência
4 - Mana
5 - Inteligência
6 - Noble Phantasm
```

O maior valor vence a rodada.

### Exemplo

```text
Mestre Arthur → Força: 90
Mestre João   → Força: 75
Mestre Pedro  → Força: 60
```

Nesse caso:

```text
🏆 Mestre Arthur vence a rodada.
```

Todas as cartas utilizadas no combate são adicionadas à mão do vencedor.

---

## 🤝 Sistema de Empate

Caso dois ou mais jogadores obtenham o mesmo maior valor no atributo escolhido, ocorre um empate.

Nesse caso:

* Nenhum jogador vence a rodada;
* As cartas permanecem na mesa;
* Elas são armazenadas no **monte acumulado**;
* Na próxima rodada, essas cartas entram novamente na disputa;
* O vencedor da próxima rodada recebe também todas as cartas acumuladas.

Isso cria a possibilidade de uma rodada futura valer muito mais cartas.

---

## 🏆 Condição de Vitória

Normalmente, a partida termina quando apenas **um jogador possui cartas**.

Esse jogador é declarado vencedor da:

> 🏆 **Guerra do Santo Graal**

Ao final da partida, o vencedor também pode informar qual seria seu desejo ao Santo Graal.

---

## ⏱️ Limite de Rodadas

Para evitar que uma partida fique presa indefinidamente, o jogo possui um limite de:

```text
150 rodadas
```

Caso esse limite seja atingido antes de existir apenas um jogador com cartas, o vencedor será o jogador que possuir a **maior quantidade de cartas**.

---

## 🃏 Estrutura das Cartas

Cada carta possui informações como:

```text
Nome
Classe
Código
Força
Velocidade
Resistência
Mana
Inteligência
Noble Phantasm
Frase
Super Trunfo
```

Exemplo de estrutura:

```csharp
new Carta(
    "Heracles",
    "BERSERKER",
    "G4",
    100,
    70,
    95,
    60,
    60,
    100,
    "Serei derrotado apenas por mim.",
    false
);
```

---

## 🧱 Estrutura do Projeto

```text
Jogo-SuperTrunfo/
│
├── Jogo-SuperTrunfo/
│   ├── Baralho.cs
│   ├── Carta.cs
│   ├── Partida.cs
│   ├── Program.cs
│   └── Jogo-SuperTrunfo.csproj
│
├── JogoSuperTrunfo.Testes/
│   ├── UnitTest1.cs
│   └── JogoSuperTrunfo.Testes.csproj
│
├── Jogo-SuperTrunfo.slnx
├── .gitignore
└── README.md
```

---

## 🧩 Principais Classes

### `Carta.cs`

Responsável pela representação das cartas do jogo.

A classe possui os atributos dos personagens e também o método:

```csharp
ExibirCarta()
```

que apresenta a carta no terminal utilizando cores e uma interface visual em ASCII.

---

### `Baralho.cs`

Responsável pela criação do conjunto de cartas utilizadas na partida.

O método:

```csharp
CriarCartas()
```

retorna as cartas que fazem parte do jogo, incluindo a carta especial do Santo Graal.

---

### `Partida.cs`

Contém a principal lógica da partida.

É responsável por:

* Criar os jogadores;
* Distribuir as cartas;
* Executar os combates;
* Comparar atributos;
* Identificar vencedores;
* Controlar empates;
* Armazenar o monte acumulado;
* Aplicar a regra do Super Trunfo.

---

### `Program.cs`

É o ponto de entrada da aplicação.

Responsável pela interação com os jogadores e pelo fluxo geral da partida:

```text
Cadastro dos Mestres
        ↓
Distribuição das cartas
        ↓
Início da partida
        ↓
Escolha do atributo
        ↓
Combate
        ↓
Determinação do vencedor
        ↓
Próxima rodada
        ↓
Vitória
        ↓
Desejo ao Santo Graal
```

---

## 🧪 Testes Automatizados

O projeto também possui um projeto separado para testes utilizando **xUnit**.

Atualmente são testadas regras básicas do combate:

* Carta com atributo maior vence;
* Atributos iguais resultam em empate;
* A segunda carta pode vencer quando possui valor maior.

Exemplo:

```csharp
[Fact]
public void TestarRegraDeCombate_CartaMaiorDeveVencer()
{
    int atributoCarta1 = 80;
    int atributoCarta2 = 50;

    bool carta1Venceu = atributoCarta1 > atributoCarta2;

    Assert.True(carta1Venceu);
}
```

---

## 💻 Tecnologias Utilizadas

* **C#**
* **.NET 10**
* **xUnit**
* **Programação Orientada a Objetos**
* **Git**
* **GitHub**

---

## 🚀 Como Executar

### Pré-requisitos

É necessário ter instalado o **.NET 10 SDK**.

### Clonar o projeto

```bash
git clone https://github.com/ArthurMorais007/Jogo-SuperTrunfo.git
```

Depois:

```bash
cd Jogo-SuperTrunfo
```

### Executar o jogo

Entre na pasta do projeto:

```bash
cd Jogo-SuperTrunfo
```

Execute:

```bash
dotnet run
```

---

## 🧪 Executar os Testes

Para executar os testes automatizados:

```bash
dotnet test
```

O comando executará os testes presentes no projeto `JogoSuperTrunfo.Testes`.

---

## 🎯 Objetivos do Projeto

O projeto busca desenvolver e aplicar conhecimentos de:

* Programação Orientada a Objetos;
* Classes e objetos;
* Encapsulamento;
* Listas e filas;
* Estruturas condicionais;
* Estruturas de repetição;
* Métodos;
* Manipulação de dados;
* Testes unitários;
* Organização de projetos;
* Controle de versão com Git e GitHub.

---

## 📚 Aprendizados

Durante o desenvolvimento do projeto, foram trabalhados conceitos importantes de desenvolvimento de software.

A criação do sistema de cartas permitiu trabalhar com **classes, objetos, propriedades e métodos**, enquanto a implementação da partida exigiu o uso de estruturas como `List`, `Queue` e `Dictionary`.

Também foi necessário desenvolver regras para situações específicas, como empates, acúmulo de cartas e o funcionamento especial do Santo Graal.

A utilização de testes automatizados também contribuiu para verificar se as principais regras de comparação dos atributos estavam funcionando corretamente.

---

## 🔮 Possíveis Melhorias Futuras

Algumas funcionalidades podem ser adicionadas em futuras versões:

* 🖼️ Interface gráfica;
* 🎴 Design visual das cartas;
* 🔊 Efeitos sonoros;
* ✨ Animações;
* 👥 Modo multiplayer;
* 🤖 Jogadores controlados por IA;
* 📊 Sistema de pontuação;
* 🃏 Mais personagens;
* ⚔️ Novas regras de combate;
* 🏆 Sistema de ranking;
* 💾 Salvamento das partidas.

---

## 👥 Projeto Acadêmico

**Fate: Noble Trunfo**

Projeto desenvolvido para fins acadêmicos, utilizando o conceito do jogo Super Trunfo com elementos inspirados no universo Fate.

---

## 🔗 Repositório

O código-fonte completo está disponível no GitHub:

**https://github.com/ArthurMorais007/Jogo-SuperTrunfo**

---

## ⚠️ Aviso

**Fate: Noble Trunfo** é um projeto acadêmico e de caráter educacional, inspirado no universo da franquia Fate e no conceito do jogo Super Trunfo.
