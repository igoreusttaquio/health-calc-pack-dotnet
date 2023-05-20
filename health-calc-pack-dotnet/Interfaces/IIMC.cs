using System;
namespace health_calc_pack_dotnet.Interfaces;

public interface IIMC
{
    double Calcular(double altura, double peso);
    string GetGategoriaIMC(double IMC);
    bool EhDadoValido(double altura, double peso);
}

