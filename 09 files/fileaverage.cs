using System;
using System.IO;
using System.Globalization;
using System.Threading;


public class fileaverage
{
    static public void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en");
        string filename = args[0];
        if (!File.Exists(filename)) return;

        float total = 0;
        float average = 0;
        int count = 0;
        foreach (string p in File.ReadLines(filename))
        {
            //float number = float.Parse(p);
            //p = number;
            float price;
            if (float.TryParse(p, out price))
            {
                total += price;
                count++;
            }
        }
        average = total / count;

        CultureInfo culture = CultureInfo.CurrentCulture;
        Console.WriteLine("The current culture is {0} [{1}]",
                          culture.NativeName, culture.Name);

        // Console.Clear();
        Console.WriteLine("The average of values in file is: {0:0.00} ", average);

    }

}