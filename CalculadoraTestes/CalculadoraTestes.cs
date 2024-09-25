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
}