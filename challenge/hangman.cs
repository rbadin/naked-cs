using System;
using System.IO;

public class Hangman
{
    static public void Main()
    {
        string[] words = File.ReadAllLines("words.txt");
        string guess = "";
        char[] guessWord;

        Random rnd = new Random();
        int wordnum = rnd.Next(0, words.Length);
        int wrong = 0;

        string wordToGuess = words[wordnum].ToLower();
        Console.WriteLine(wordToGuess);
        guessWord = new char[wordToGuess.Length];
        for (int i = 0; i < guessWord.Length; i++)
        {
            guessWord[i] = '_';
        }
        while (new string(guessWord) != wordToGuess && wrong < 10)
        {
            Console.Write("Advinhe uma letra: ");
            guess = Console.ReadLine().ToLower();
            Console.Clear();

            bool found = false;
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (guess[0] == wordToGuess[i])
                {
                    guessWord[i] = guess[0];
                    found = true;
                }
            }
            if (!found)
            {
                wrong ++;
                Console.WriteLine("Errou.");
            }
        Console.WriteLine(new string(guessWord));
        Console.WriteLine();

        PrintHangman(wrong);
        }
    }

    static void PrintHangman(int wrongTimes)
    {
        if (wrongTimes > 3)
            Console.WriteLine("__________ ");
        if (wrongTimes > 4)
            Console.WriteLine(" |/      | ");
        else if (wrongTimes > 2)
            Console.WriteLine(" |/      ");

        if (wrongTimes > 8)
        {
            Console.WriteLine(" |      (_) ");
            Console.WriteLine(" |      \\|/ ");
            Console.WriteLine(" |       |  ");
            Console.WriteLine(" |      / \\ ");
        }
        else if (wrongTimes > 7)
        {
            Console.WriteLine(" |      (_) ");
            Console.WriteLine(" |      \\|/ ");
            Console.WriteLine(" |       |  ");
            Console.WriteLine(" | ");
        }
        else if (wrongTimes > 6)
        {
            Console.WriteLine(" |      (_) ");
            Console.WriteLine(" |      \\|/ ");
            Console.WriteLine(" | ");
            Console.WriteLine(" | ");
        }
        else if (wrongTimes > 5)
        {
            Console.WriteLine(" |      (_) ");
            Console.WriteLine(" | ");
            Console.WriteLine(" | ");
            Console.WriteLine(" | ");
        }
        else if (wrongTimes > 1)
        {
            Console.WriteLine(" | ");
            Console.WriteLine(" | ");
            Console.WriteLine(" | ");
            Console.WriteLine(" | ");
        }
        if (wrongTimes > 0)
            Console.WriteLine("_|___");
    }
}