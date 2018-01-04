using System;
using System.IO;

public class fileaverage
{
    static public void Main(string[] args)
    {
        string filename = args[0];
        if (!File.Exists(filename)) return;

        float total = 0;
        float average = 0;
        int count = 0;
        foreach (string p in File.ReadLines(filename))
        {
            float price;
            if (float.TryParse(p, out price))
            {
                total += price;
                count++;
            }
        }
        average = total / count;

        Console.Clear();
        Console.WriteLine("The average of values in file is: {0:0.00} ", average);

    }

}