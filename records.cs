using System;

public class Records
{
    static public void Main()
    {
        Person p1 = new Person("Rodrigo", "Rua Alpha", "12-12123", 179.5f);
        Person p2 = new Person("Paty", "Rua Beta", "50-85909", 145.5f);

        Console.Clear();
        p1.PrintDetails();
        p2.PrintDetails();
        
    }
}