using System;
using health_calc_pack_dotnet.Enums;
using health_calc_pack_dotnet.Interfaces;
using health_calc_pack_dotnet.Models;

namespace health_calc_pack_dotnet;

public class MacroNutrientes 
{
    private IMacroNutrientesStrategy MacroNutrientesStrategy { get; }

    public MacroNutrientes(IMacroNutrientesStrategy macroNutrientesStrategy)
    {
        MacroNutrientesStrategy = macroNutrientesStrategy;
    }

    public MacroNutrientesModel CalcularMacroNutrientes(double peso)
    {
        return MacroNutrientesStrategy.CalcularMacroNutrientes(peso);
    }
}

