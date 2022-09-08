using System;
using System.Text;

public class NumberPairs
{
	public static void Main(string[] args)
	{
		StringBuilder noMatch = new StringBuilder("", 261);
		for (int i = 99; i > 0; i--)
		{
			string numberAsText = Convert.ToString(i);
			if (numberAsText.Length > 1 && Int32.Parse((numberAsText[0].ToString())) + Int32.Parse((numberAsText[1].ToString())) == 10)
			{
				Console.WriteLine($"Match found for {numberAsText}: ({numberAsText[0]},{numberAsText[1]})");
			}
			else
			{
				noMatch.Append($"{i},");
			}
		}

		Console.WriteLine("\nNo match found for:\n");
		Console.WriteLine(noMatch.ToString(0, noMatch.Length - 1));
	}
}