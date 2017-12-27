using System;

public class CeasarCypher
{
    static public void Main()
    {
        string plaintext;
        // Console.Clear();
        Console.Write("Entre seu texto: ");
        plaintext = Console.ReadLine();

        foreach (char c in plaintext)
        {
            if (c == ' ')
                Console.Write(" ");
            else
            {
                char letter = c;
                if (letter >= 'X' && letter <= 'Z')
                {
                    letter = (char) (letter - 26);
                }
                else if (letter >= 'x' && letter <= 'z')
                {
                    letter = (char) (letter - 26);
                }
                Console.Write("{0}", (char) (letter + 3));
            }
        }
        Console.WriteLine("");
    }
}