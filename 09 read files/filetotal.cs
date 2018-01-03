using System;
using System.IO;

public class filetotal
{
    static public void Main(string[] args)
    {
        string filename = args[0];
        if (!File.Exists(filename)) return;

        float total = 0;
        foreach (string p in File.ReadLines(filename))
        {
            float price;
            if (float.TryParse(p, out price))
                total += price;
        }

        Console.Clear();
        Console.WriteLine("The total of values in file is: \n" + total);

    }

}