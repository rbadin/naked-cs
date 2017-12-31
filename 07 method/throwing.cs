using System;

public class ThrowingExample
{
    static public void Main()
    {
        int i = 0;
        Console.Write("Entre um integer: ");

        try
        {
            i = GetInteger();
        }
        catch (Exception ex)
        {
            Console.WriteLine("A entrada foi incorreta.");
        }
    }

    static int GetInteger(){
        string input = Console.ReadLine();
        int val;
        if (!int.TryParse(input, out val))
        {
            throw new Exception();
        }
        return val;
    }
}