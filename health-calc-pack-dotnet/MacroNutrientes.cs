using System;
using health_calc_pack_dotnet.Enum;
using health_calc_pack_dotnet.Interface;
using health_calc_pack_dotnet.Models;

namespace health_calc_pack_dotnet;

public class MacroNutrientes : IMacroNutrientes
{
    private MacroNutrientesModel? MacroNutrientesModel;

    public MacroNutrientesModel CalcularMacroNutrientes(ObjetivoFisicoEnum objetivoFicico, double peso)
    {
        if (objetivoFicico is ObjetivoFisicoEnum.PerdaPeso)
        {
            MacroNutrientesModel = new MacroNutrientesModel(carboidrato: 3.0 * peso, proteina: 4.0 * peso, gordura: 3.0 * peso);
        }
        else if (objetivoFicico is ObjetivoFisicoEnum.ManterPeso)
        {
            MacroNutrientesModel = new MacroNutrientesModel(carboidrato: 4.0 * peso, proteina: 4.0 * peso, gordura: 2.0 * peso);
        }
        else
        {
            MacroNutrientesModel = new MacroNutrientesModel(carboidrato: 4.0 * peso, proteina: 2.0 * peso, gordura: 1.0 * peso);
        }
        
        return MacroNutrientesModel;
    }
}

