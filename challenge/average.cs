using System;
using System.IO;

class FileTotal
{
	static void Main()
	{
		string filename = "prices.txt";
		if(!File.Exists(filename)) return;

		float total = 0;
		int count = 0;
		foreach(string p in File.ReadLines(filename))
		{
			float price;
			if(float.TryParse(p, out price))
			{
				count++;
				total += price;
			}
		}
		Console.Clear();
		Console.WriteLine("Average of values in file is {0:0.00} ",(total/count));
	}
}