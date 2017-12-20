using System;

public class StringExplorer
{
    static public void Main ()
    {
        string name, job, company;
        string s = "My name is Rodrigo";
        s += " Badin";
        Console.WriteLine ("{0}\n({1} - characters)", s, s.Length);
    }
}