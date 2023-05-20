using System;
using health_calc_pack_dotnet;
using health_calc_pack_dotnet.Interfaces;

namespace health_calc_pack_dotnet_test.PackLibrary;

public class IMCTest
{
    [Fact]
    public void CalculaIMC_QuandoDadosValidos_EntaoRetornaIndice()
    {
        //Arrange
        IIMC imc = new IMC();
        double altura = 1.73;
        double peso = 72;
        double IMCEsperado = 24.06;

        //Act
        double resultado = imc.Calcular(altura, peso);

        //Asserts
        Assert.Equal(IMCEsperado, resultado);
    }

    [Fact]
    public void ValidaDadosIMC_QuandoDadosInvalidos_EntaoRetornaFalso()
    {
        //Arrange
        IIMC imc = new IMC();
        double altura = 10.0;
        double peso = 400.0;

        //Act
        bool resultado = imc.EhDadoValido(altura, peso);

        //Asserts
        Assert.False(resultado);
    }

    [Theory]
    [InlineData(17, IMCConstants.MAGREZA)]
    [InlineData(24, IMCConstants.NORMAL)]
    [InlineData(26, IMCConstants.SOBREPESO)]
    [InlineData(30.55, IMCConstants.OBESIDADE)]
    [InlineData(42, IMCConstants.OBESIDADE_GRAVE)]
    public void RetornaCategoriaIMC_QuandoIndiceValido_EntaoRetornaDescricao(double valorIMC, string classificacao)
    {
        //Arrange
        IIMC imc = new IMC();

        //Act
        string resultado = imc.GetGategoriaIMC(valorIMC);

        //Asserts
        Assert.Equal(classificacao, resultado);
    }
}

