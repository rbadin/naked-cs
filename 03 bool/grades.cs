using System;

public class GradeCalculator
{
    static public void Main()
    {
        string result;

        Console.Clear();
        Console.Write("Qual é o resultado final? ");
        result = Console.ReadLine();
        result = GetResult(result);
        Console.WriteLine("Sua nota é {0}.", result);
    }

    private string GetResult(string text)
    {
        int result = Convert.ToInt32(text);

        if (result >= 95)
        {
            return "A";
        }
        else if (result >= 85)
        {
            return "B";
        }
        else if (result >= 75)
        {
            return "C";
        }
        else if (result >= 50)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }
}