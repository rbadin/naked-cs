using System;

public class wordOrder
{
    static public void Main()
    {
		string word1 = "apple";
		string word2 = "orange";

		Console.Clear();
		if(String.Compare(word1,word2) < 0)
		{
			Console.WriteLine("{0} comes before {1}", word1, word2);
		}
		else if (String.Compare(word1,word2) > 0)
		{
			Console.WriteLine("{0} comes before {1}", word2, word1);
		}
		else
		{
			Console.WriteLine("The words are the same.");
		}
    }

}