using System;

public class CeasarCypher
{
    static public void Main()
    {
        string plaintext;
        int numShift;
        Console.Clear();
        Console.Write("Entre seu texto: ");
        plaintext = Console.ReadLine();
        Console.Write("Mudar por quantas letras? ");
        numShift = Convert.ToInt32(Console.ReadLine());
        foreach (char c in plaintext)
        {
            if (c == ' ')
                Console.Write(" ");
            else
            {
                char letter = c;
                if (letter > ('Z' - numShift) && letter <= 'Z')
                {
                    letter = (char) (letter - 26);
                }
                else if (letter > ('z' - numShift) && letter <= 'z')
                {
                    letter = (char) (letter - 26);
                }
                Console.Write("{0}", (char) (letter + numShift));
            }
        }
        Console.WriteLine("");
    }
}