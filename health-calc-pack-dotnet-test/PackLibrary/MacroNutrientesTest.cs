using System;
using System.Drawing;
using health_calc_pack_dotnet;
using health_calc_pack_dotnet.MacroNutrientesStrategies;
using health_calc_pack_dotnet.Models;
using static health_calc_pack_dotnet_test.PackLibrary.MacroNutrientesTest;

namespace health_calc_pack_dotnet_test.PackLibrary;

public class MacroNutrientesTest
{
    /*[Fact]
	public void Method()
	{
		// Arrange

		// Act

		// Assert
	}*/

    public enum ObjetivoEnum
    {
        PERDER_PESO,
        MANTER_PESO,
        GANHAR_MASSA_MUSCULAR
    }
    [Theory]
    [InlineData(ObjetivoEnum.PERDER_PESO, 266.4, 355.2, 266.4)]
    [InlineData(ObjetivoEnum.MANTER_PESO, 355.2, 355.2, 177.6)]
    [InlineData(ObjetivoEnum.GANHAR_MASSA_MUSCULAR, 355.2, 177.6, 88.8)]
    public void CalculaMacroNutrientes_QuandoDadosValidos_EntaoRetornaVerdadeiro(ObjetivoEnum objetivo, double carboidratos, double preteinas, double gorduras)
	{
		// Arrange
		MacroNutrientesModel esperado = new(carboidratos, preteinas, gorduras);
		MacroNutrientesConext context = new();
        double peso = 88.80;

        switch (objetivo)
        {
            case ObjetivoEnum.PERDER_PESO:
                context.SetStrategy(new PerderPesoStrategy());
                break;
            case ObjetivoEnum.MANTER_PESO:
                context.SetStrategy(new ManterPesoStrategy());
                break;
            case ObjetivoEnum.GANHAR_MASSA_MUSCULAR:
                context.SetStrategy(new GanharMassaMuscularStrategy());
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(objetivo), $"Objetivo: não esperado");
        }

        // Act
        MacroNutrientesModel resultado = context.ExecuteStratery(peso)!;

		// Assert
		Assert.Equal(esperado, resultado);
    }

    [Theory]
    [InlineData(ObjetivoEnum.PERDER_PESO, 266.4, 355.2, 266.4)]
    [InlineData(ObjetivoEnum.MANTER_PESO, 355.2, 355.2, 177.6)]
    [InlineData(ObjetivoEnum.GANHAR_MASSA_MUSCULAR, 355.2, 177.6, 88.8)]
    public void CalculaMacroNutrientes_QuandoDadosValidos_EntaoRetornaFalso(ObjetivoEnum objetivo, double carboidratos, double preteinas, double gorduras)
    {
        // Arrange
        MacroNutrientesModel esperado = new(carboidratos, preteinas, gorduras);
        MacroNutrientesConext context = new();
        double peso = 80.0;

        switch (objetivo)
        {
            case ObjetivoEnum.PERDER_PESO:
                context.SetStrategy(new PerderPesoStrategy());
                break;
            case ObjetivoEnum.MANTER_PESO:
                context.SetStrategy(new ManterPesoStrategy());
                break;
            case ObjetivoEnum.GANHAR_MASSA_MUSCULAR:
                context.SetStrategy(new GanharMassaMuscularStrategy());
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(objetivo), $"Objetivo: não esperado");
        }

        // Act
        MacroNutrientesModel resultado = context.ExecuteStratery(peso)!;

        // Assert
        Assert.NotEqual(esperado, resultado);
    }
}

