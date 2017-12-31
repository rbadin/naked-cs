using System;

public class CheapestPrice
{
    static public void Main()
    {
        float[] breadPrices = { 3.45f, 3.10f, 2.56f, 2.05f, 3.95f };
        float[] milkPrices = { 1.50f, 2.50f, 1.75f, 2.05f, 1.25f, 2.35f, 3.05f };
        float[] eggPrices = { 4.50f, 3.65f, 2.90f, 4.10f };

        Console.Clear();

        Console.WriteLine("Menor preço do pão: ${0}", MinCalc(breadPrices));
        Console.WriteLine("Menor preço do leite: ${0}", MinCalc(milkPrices));
        Console.WriteLine("Menor preço do ovo: ${0}", MinCalc(eggPrices));
    }

    static public float MinCalc(float[] values)
    {
        float minimum = values[0];
        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] < minimum)
                minimum = values[i];
        }
        return minimum;
    }
}