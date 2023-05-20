namespace health_calc_pack_dotnet.Models;

public class MacroNutrientesModel
{
    public double Carboidrato { get; }
    public double Proteina { get; }
    public double Gordura { get; }

    public MacroNutrientesModel(double carboidrato, double proteina, double gordura)
    {
        Carboidrato = carboidrato;
        Proteina = proteina;
        Gordura = gordura;
    }
}