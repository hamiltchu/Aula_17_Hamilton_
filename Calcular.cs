using System;

public class Calcular
{
    public float Numero1;
    public float Numero2;
    public float Soma()
    {
        return  Numero1 + Numero2;
    }

    public float Subtracao()
    {
        return Numero1 - Numero2;
    }
    public float Multiplicacao()
    {
        return Numero1 * Numero2;

    }

    public float Divisao()
    {
        if (Numero2 != 0)
        {

        return Numero1 / Numero2;
        }else
        {
    
        Console.WriteLine("Não foi possível divisão por 0");
        return 0;
        }
    }
}