using System;

public class Maths
{
    static public void Main()
    {
        string number1;
        string number2;
        int num1;
        int num2;
        Console.Clear();
        Console.Write("Please enter value 1: ");
        number1 = Console.ReadLine();
        Console.Write("Please enter value 2: ");
        number2 = Console.ReadLine();

        num1 = Convert.ToInt32(number1);
        num2 = Convert.ToInt32(number2);

        Console.WriteLine("The addition of {0} and {1} is {2}", num1, num2, num1 + num2);
        //C = 2*pi*r
        // string radius;
        // Console.Clear();
        // Console.Write("Please enter the radius: ");
        // radius = Console.ReadLine();

        // float rad = Convert.ToSingle(radius);
        // float c = 2 * 3.14f * rad;
        // Console.WriteLine("The circumference is {0}", c);

        // F = C * 9/5 + 32
        // float f;
        // float c = 24;
        // f = c * 9/5 + 32;

        // Console.WriteLine("{0} Celsius is is equal to {1} Fahrenheit", c, f);

        // F = ma
        // float force;
        // float mass = 3;
        // float acceleration = 10.5f;
        // force = mass * acceleration;

        // Console.WriteLine ("Force is equal to {0}", force);
    }
}