using System;
using System.Threading;

public class ArrayDoidao
{
    static public void Main()
    {
        var[,] fooddata = new var[5,6]  {
                                        {976, 660, 32, 48, 0, 40},
                                        {246, 127,  9, 13, 0,  5},
                                        {250, 128, 18, 13, 1,  4},
                                        { 17,  70,  4,  6, 0, 11},
                                        {100, 150, 12,  6, 0, 12}
                                        };
        for (int x = 0; x < length; x++)
        {
            for (int y = 0; y < length; y++)
            {
                Console.Write("{0}", fooddata[x,y]);
            }
        }

        Console.WriteLine("{0}", fooddata[4,5]);
    }
}