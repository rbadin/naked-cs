using System;

public class BooleanTester
{
	static public void Main()
	{
		Random rand = new Random();
		bool a = Convert.ToBoolean(rand.Next(2));
		bool b = Convert.ToBoolean(rand.Next(2));
		bool c = Convert.ToBoolean(rand.Next(2));
		bool answer;

		Console.Clear();
		Console.WriteLine("Answer with True for TRUE or False for FALSE.");
		// Console.WriteLine("A is {0}, B is {1}, C is {2}", a, b, c);

		//question 1
		Console.WriteLine("What is {0} && {1}?", a, b);
		answer = Convert.ToBoolean(Console.ReadLine());
		if (answer == (a && b))
		{
			Console.WriteLine("CORRECT");
		}
		else
		{
			Console.WriteLine("WRONG");
		}

		//question 2
		Console.WriteLine("What is {0} || {1}?", a, c);
		answer = Convert.ToBoolean(Console.ReadLine());
		if (answer == (a || c))
		{
			Console.WriteLine("CORRECT");
		}
		else
		{
			Console.WriteLine("WRONG");
		}

		//question 3
		Console.WriteLine("What is {0} || {2} && {1}?", a, b, c);
		answer = Convert.ToBoolean(Console.ReadLine());
		if (answer == (a || c && b))
		{
			Console.WriteLine("CORRECT");
		}
		else
		{
			Console.WriteLine("WRONG");
		}

		//question 4
		Console.WriteLine("What is {0} && {2} && {1}?", a, b, c);
		answer = Convert.ToBoolean(Console.ReadLine());
		if (answer == (a && c && b))
		{
			Console.WriteLine("CORRECT");
		}
		else
		{
			Console.WriteLine("WRONG");
		}

		//question 5
		Console.WriteLine("What is {0} || {1} && {1}?", a, b );
		answer = Convert.ToBoolean(Console.ReadLine());
		if (answer == (a || b && b))
		{
			Console.WriteLine("CORRECT");
		}
		else
		{
			Console.WriteLine("WRONG");
		}

		//question 6
		Console.WriteLine("What is {0} && ({1} || {2})?",a,b,c);
		answer = Convert.ToBoolean(Console.ReadLine());
		if (answer == (a && (b || c)))
		{
			Console.WriteLine("CORRECT");
		}
		else
		{
			Console.WriteLine("WRONG");
		}

	}
}