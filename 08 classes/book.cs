using System;

public class Book
{
    string title;
    string author;

    public Book(string t, string a)
    {
        title = t;
        author = a;
    }

    public void Print()
    {
        Console.WriteLine(title + " by " + author);
    }
}