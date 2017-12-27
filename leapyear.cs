using System;

class LeapYear
{
    static public void Main()
    {
        // Um ano bissexto é um ano divisível por 4
        // Mas um ano divisível por 100 não é bissexto
        // a menos que seja divisível por 400

        int year, test1, test2, test3;

        Console.Clear();
        Console.Write("Digite um ano: ");
        year = Convert.ToInt32(Console.ReadLine());

        test1 = year % 4;
        test2 = year % 100;
        test3 = year % 400;

        if ((test1 == 0 && test2 != 0) || test3 == 0)
        {
            Console.WriteLine("O ano é bissexto!");
        }
        else
        {
            Console.WriteLine("O ano não é bissexto!");
        }

    }
}