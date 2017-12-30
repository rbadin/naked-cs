using System;

public class OutExample
{
    static public void Main()
    {
        string input;
        int number;

        Console.Clear();
        Console.Write("Entre um número: ");
        input = Console.ReadLine();

        if (int.TryParse(input, out number))
        {
            number += 1;
            Console.WriteLine("Obrigado");
        }
        else
        {
            number = 666;
            Console.WriteLine("Entrada incorreta");
        }
        Console.WriteLine(number);

    }
}