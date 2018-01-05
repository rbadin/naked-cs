using System;
using System.IO;
using System.Globalization;
using System.Threading;

public class filetotal
{
    static public void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en");
        string filename = args[0];
        if ((!File.Exists(filename))) return;

        float total = 0;
        foreach (string p in File.ReadLines(filename))
        {
            float price;
            if (float.TryParse(p, out price))
                total += price;
        }
        Console.Clear();
        CultureInfo culture = CultureInfo.CurrentCulture;
        Console.WriteLine("The current culture is {0} [{1}]",
                          culture.NativeName, culture.Name);
        Console.WriteLine("The total of values in file is: " + total);

    }

}