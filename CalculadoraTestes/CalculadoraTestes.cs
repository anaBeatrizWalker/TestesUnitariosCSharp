using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImp _calc;

    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15() //nome o mais descritivo possível e informando o que recebe e o que retorna
    {
        //Arrange (montar o cenário)
        int num1 = 5;
        int num2 = 10;

        //Act (ações)
        int resultado = _calc.Somar(num1, num2);

        //Assert (validação do resultado)
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        //Arrange
        int numero = 4;

        //Act
        bool resultado = _calc.EhPar(numero);

        //Assert
        Assert.True(resultado);
    }

    [Theory] //conjunto de cenários que vão passar pelo mesmo teste
    [InlineData(2)] //cada inline data é um teste diferente que passa um parâmetro para o teste
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int numero)
    {
        //Act
        bool resultado = _calc.EhPar(numero);

        //Assert
        Assert.True(resultado);
    }
}