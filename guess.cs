using System;

public class Guess
{
    static public void Main()
    {
        int number = 90;
        int guess;

        Console.Clear();
        do {
            Console.Write("\nQue número estou pensando? ");
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess < number)
            {
                Console.WriteLine("O número é maior.");
            }
            else if (guess > number)
            {
                Console.WriteLine("O número é menor");
            }
            else
            {
                Console.WriteLine("Acertô mizeravi!");
            }
        } while (guess != number);
    }
}