using System;

public class NameBadge
{
    static public void Main ()
    {
        string name, job, company;
        Console.Write ("Seu nome: ");
        name = Console.ReadLine ();
        Console.Write ("Cargo: ");
        job = Console.ReadLine ();
        Console.Write ("Empresa: ");
        company = Console.ReadLine ();
        Console.WriteLine ("|****************|");
        Console.WriteLine ("|Nome: {0,10}|", name);
        Console.WriteLine ("|{0,16}|", job);
        Console.WriteLine ("|----------------|");
        Console.WriteLine ("|{0,16}|", company);
        Console.WriteLine ("|****************|");
    }
}