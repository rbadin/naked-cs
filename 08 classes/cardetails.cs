using System;

public class CarDetails
{
    string make;
    string model;
    int year;
    string color;

    public CarDetails(string m, string mod, int y, string c)
    {
        make = m;
        model = mod;
        year = y;
        color = c;
    }

    public void PrintDetails()
    {
        Console.WriteLine("Marca: " + make);
        Console.WriteLine("Modelo: " + model);
        Console.WriteLine("Ano: " + year);
        Console.WriteLine("Cor: " + color +"\n");
    }

}