using System;
using health_calc_pack_dotnet.Enum;
using health_calc_pack_dotnet.Models;
namespace health_calc_pack_dotnet.Interface;

public interface IMacroNutrientesStrategy
{
    MacroNutrientesModel CalcularMacroNutrientes(ObjetivoFisicoEnum objetivoFicico, double peso);
}

