using System;

public class CollectionArray
{
    static public void Main()
    {
        CarDetails[] myCars = new CarDetails[2];
        string make;
        string model;
        int year;
        string color;

        for (int i = 0; i < myCars.Length; i++)
        {
            Console.WriteLine("Entre detalhes para o carro {0}: ", i+1);
            Console.Write("Marca: ");
            make = Console.ReadLine();
            Console.Write("Modelo: ");
            model = Console.ReadLine();
            Console.Write("Ano: ");
            year = GetNumber();
            Console.Write("Cor: ");
            color = Console.ReadLine();

            myCars[i] = new CarDetails(make, model, year, color);
            
        }

        Console.Clear();
        
        for (int i = 0; i < myCars.Length; i++)
        {
            myCars[i].PrintDetails();
        }

    }

    static int GetNumber()
    {
        int val;
        
        GetInput:
        string input = Console.ReadLine();

        if (!int.TryParse(input, out val))
        {
            Console.Write("Valor inválido, insira o valor novamente: ");
            goto GetInput;
        }
        return val;

    }

}