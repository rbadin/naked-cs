using System;

class Sample 
{
    public static void Main(String[] args) 
    {
    int x = 0;
//
    if ((args.Length == 1) &&
        (Int32.TryParse(args[0], out x) == true) &&
        ((x >= 1) && (x <= 9)))
        {
        for (int i = 1; i <= x; i++)
            {
            Console.WriteLine("Beep number {0}.", i);
            Console.Beep();
            }
        }
    else
        Console.WriteLine("Usage: Enter the number of times (between 1 and 9) to beep.");
    }
}