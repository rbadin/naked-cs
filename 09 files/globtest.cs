using System;
using System.Globalization;

public class GlobalizationTest
{
    static public void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en");

        string myNumber;
        Console.WriteLine("Qual é o número?");
        myNumber = Console.ReadLine();
        
        Console.WriteLine(Convert.ToSingle(myNumber));
        Console.WriteLine(Convert.ToSingle(myNumber, numberFormat));
    }
}