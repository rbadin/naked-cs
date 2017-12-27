using System;

public class GuessGame
{
    static public void Main()
    {
        Random rand = new Random();
        int number = rand.Next(1, 101);
        int guess;

        Console.Clear();
        Console.Write("Que número estou pensando? ");
        guess = Convert.ToInt32(Console.ReadLine());

        while (guess != number)
        {
            Console.Write("Desculpa, errou. ");
            
            if (guess < number)
            {
                Console.Write("O número é maior. ");
            }
            else
            {
                Console.Write("O número é menor. ");
            }
            guess = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Acertou mizeravi!");
    }
}