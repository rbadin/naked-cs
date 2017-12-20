using System;

public class HypotenuseCalc
{
    static public void Main ()
    {
        string sideA;
        string sideB;

        Console.Clear ();
        Console.WriteLine ("Vamos calcular a hipotenusa!");
        Console.Write ("Por favor entre o comprimento do lado A: ");
        sideA = Console.ReadLine ();
        Console.Write ("Por favor entre o comprimento do lado B: ");
        sideB = Console.ReadLine ();

        float a = Convert.ToSingle (sideA);
        float b = Convert.ToSingle (sideB);
        double h2 = Math.Pow (a, 2) + Math.Pow (b, 2);
        double h = Math.Sqrt(h2);

        Console.WriteLine ("O comprimento da hipotenusa é {0}", h);
    }
}