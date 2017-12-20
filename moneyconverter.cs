using System;

public class MoneyConverter
{
    static public void Main()
    {
        string rate;
        string dollars;

        Console.Clear();
        Console.Write("Entre com o valor do dólar em reais: ");
        rate = Console.ReadLine();
        Console.Write("Entre com o valor em dólares: ");
        dollars = Console.ReadLine();

        float r = Convert.ToSingle(rate);
        float d = Convert.ToSingle(dollars);

        float amount = d * r;

        System.Console.WriteLine("Você paga: R$ {0}", amount);
    }
}