string noMatch = "";

for (int i = 99; i > 0; i--)
{
    string stringedInt = i.ToString();

    if (stringedInt.Length > 1 && Int32.Parse((stringedInt[0].ToString())) + Int32.Parse((stringedInt[1].ToString())) == 10)
    {
        Console.WriteLine($"Match found for {stringedInt}: ({stringedInt[0]},{stringedInt[1]})");
    }
    else
    {
        noMatch += stringedInt + ',';
    }
}

Console.WriteLine("\nNo match found for:\n");
Console.WriteLine(noMatch.Substring(0, noMatch.Length - 1));

//Don't need tryParse
//short circuit
//ToString().ToString()

//https://stackoverflow.com/questions/829174/is-there-an-easy-way-to-turn-an-int-into-an-array-of-ints-of-each-digit