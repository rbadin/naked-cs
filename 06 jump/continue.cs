using System;

public class ContinueStatement
{
    static public void Main()
    {
        string fileContents = Console.In.ReadToEnd();
        Console.Clear();

        string[] lines = fileContents.Split('\n');

        foreach (string l in lines)
        {
            if (l.IndexOf("NULL") >= 0  || l == lines [0]) //Ignora linhas com NULL e a primeira linha que não possuí dados
            {
                continue;
            }
            string[] fields = l.Split(','); // Divide os dados pelas vírgulas
            float lat = Convert.ToSingle(fields[2]); // Pega o valor da latitude
            if (lat < 0) 
            {
                Console.WriteLine("{0}", fields[1]); // Imprime o nome da capital
            }
        }

    }
}