using System;
using System.IO;

public class FileWriting
{
    static public void Main()
    {
        string userInput;
        Console.Clear();
        Console.Write("Entre seu nome: ");
        userInput = Console.ReadLine();
        
        File.WriteAllText("details.txt", userInput);
    }
}