using health_calc_pack_dotnet;
using health_calc_pack_dotnet.MacroNutrientesStrategies;
using health_calc_pack_dotnet.Models;

MacroNutrientesConext strategy = new();
strategy.SetStrategy(new GanharMassaMuscularStrategy());
MacroNutrientesModel resultado = strategy.ExecuteStratery(88.8)!;
string complemento = "ganho de massa muscular";

string texto = $@"Para uma dieta de {complemento}, consuma:
{resultado.Carboidratos}g kilo de carboidratos, {resultado.Proteinas}g kilo de proteínas e {resultado.Gorduras}g kilo de gorduras.";

Console.WriteLine(texto);

strategy.SetStrategy(new PerderPesoStrategy());
resultado = strategy.ExecuteStratery(88.8)!;
complemento = "perda de peso";
texto = $@"Para uma dieta de {complemento}, consuma:
{resultado.Carboidratos}g kilo de carboidratos, {resultado.Proteinas}g kilo de proteínas e {resultado.Gorduras}g kilo de gorduras.";
Console.WriteLine(texto);

strategy.SetStrategy(new ManterPesoStrategy());
resultado = strategy.ExecuteStratery(88.8)!;
complemento = "manter peso";
texto = $@"Para uma dieta de {complemento}, consuma:
{resultado.Carboidratos}g kilo de carboidratos, {resultado.Proteinas}g kilo de proteínas e {resultado.Gorduras}g kilo de gorduras.";
Console.WriteLine(texto);

Console.ReadKey();