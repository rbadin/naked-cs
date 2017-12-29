using System;

public class Functions
{
    static public void Main()
    {
        float[] values = { 1.02f, 4.32f, 12.2f };
        Console.WriteLine("  Value          Ceiling          Floor\n");
        foreach (float v in values)
        {
            Console.WriteLine("{0,7} {1,16} {2,14}", v, Math.Ceiling(v), Math.Floor(v));
        }
    }
}