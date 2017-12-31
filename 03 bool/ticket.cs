using System;

class Ticket
{
    static public void Main()
    {
        string name;
        int birthYear;
        float ticketPrice;

        Console.Write("Seu nome: ");
        name = Console.ReadLine();
        Console.Write("Ano de nascimento: ");
        birthYear = Convert.ToInt32(Console.ReadLine());
        

        if (birthYear < 1950 || birthYear > 2000)
        {
            ticketPrice = 5.30f;
        }
        else
        {
            ticketPrice = 25f;
        }

        Console.WriteLine("|*****************|");
        Console.WriteLine("| -- Admite Um -- |");
        Console.WriteLine("|Nome: {0,11}|",name);
        Console.WriteLine("|Preço: $ {0,8}|",ticketPrice);
        Console.WriteLine("|*****************|");
    }
}