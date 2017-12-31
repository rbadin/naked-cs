using System;

public class Library
{
    static void Main()
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Blue;
        Book b1 = new Book("Brave New World", "Aldous Huxley");
        Book b2 = new Book("War of the Worlds", "HG Wells");

        Console.Clear();
        b1.Print();
        b2.Print();
    }
}
