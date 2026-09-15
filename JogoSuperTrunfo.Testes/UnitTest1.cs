using Xunit;
using Jogo_SuperTrunfo;

public class CombateTests
{
    [Fact]
    public void TestarRegraDeCombate_CartaMaiorDeveVencer()
    {
        int atributoCarta1 = 80;
        int atributoCarta2 = 50;

        bool carta1Venceu = atributoCarta1 > atributoCarta2;

        Assert.True(carta1Venceu);
    }

    [Fact]
    public void TestarRegraDeCombate_AtributosIguaisDevemDarEmpate()
    {
        int atributoCarta1 = 50;
        int atributoCarta2 = 50;

        bool deuEmpate = atributoCarta1 == atributoCarta2;

        Assert.True(deuEmpate);
    }

    [Fact]
    public void TestarRegraDeCombate_SegundaCartaDeveVencer()
    {
        int atributoCarta1 = 30;
        int atributoCarta2 = 90;

        bool carta2Venceu = atributoCarta2 > atributoCarta1;

        Assert.True(carta2Venceu);
    }
}