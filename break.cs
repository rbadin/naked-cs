using System;
using System.Net;

public class BreakStatement
{
    static public void Main()
    {
        Console.Clear();

        string word;
        string url;
        Console.Write("Palavra a pesquisar: ");
        word = Console.ReadLine();
        Console.Write("URL: ");
        url = Console.ReadLine();

        WebClient wc = new WebClient();

        string webText = wc.DownloadString(url);

        string[] words = webText.Split(' ');
        foreach (string w in words)
        {
            if (w.ToUpper() == word.ToUpper())
            {
                Console.WriteLine("{0} encontrado.", word);
                break;
            }
        }

    }
}