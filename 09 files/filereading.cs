using System;
using System.IO;

public class wordOrder
{
    static public void Main()
    {
        string text = File.ReadAllText("limerick.txt");

        Console.WriteLine("Conteúdo do arquivo: \n" + text);

        string[] words = text.Split(' ');

        Console.Clear();

        foreach (string w in words)
        {
            Console.WriteLine(w);
        }
        
    }

}