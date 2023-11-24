using System;

public decimal CalculadoraIMC
{
    public decimal cPeso;
    public decimal cAltura;




    public CalculadoraIMC(string? cPeso, string cAltura)
    {
        decimal peso = (decimal) Peso;
        decimal altura = (decimal) Altura;
        decimal imc = peso / (altura * altura);
        return CalculadoraIMC;

    }

}