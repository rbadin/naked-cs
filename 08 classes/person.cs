using System;

public class Person
{
    string name = "";
    string address = "";
    string phone = "";
    float height = 0;

    public Person(string n, string a, string p, float h)
    {
        name = n;
        address = a;
        phone = p;
        height = h;
    }

    public void PrintDetails()
    {
        Console.WriteLine("Nome: {0}\n"+
                          "Endereço: {1}\n"+
                          "Telefone: {2}\n"+
                          "Altura: {3}\n",
                           name, address, phone, height);
    }
}