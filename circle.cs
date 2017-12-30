using System;

public class CircleCalcs
{
    static public void Main()
    {
        string input;
        int radius;
        double c;
        double a;

        Console.Clear();
        Console.Write("Entre como o raio: ");
        input = Console.ReadLine();

        if (int.TryParse(input, out radius)) // Se for número é verdadeiro
        {
            if(circle(radius, out c, out a)) // Se for diferente de zero é verdadeiro
            {
                Console.WriteLine("Um círculo com raio {0} tem uma circunferência de {1:0.00} e área de {2:0.000}.", radius, c, a);
            }
            else
            {
                Console.WriteLine("Raio de zero!");
            }
        }
        else
        {
            Console.WriteLine("Entrada incorreta!");
        }

    }


    static bool circle(int radius, out double circumference, out double area)
    {
        circumference = 0;
        area = 0;
        if (radius == 0) return false;
        circumference = 2 * Math.PI * radius;
        area = Math.PI * Math.Pow(radius, 2);
        return true;
    }
}