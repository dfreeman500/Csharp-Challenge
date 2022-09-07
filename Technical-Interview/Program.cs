string noMatch = "";

for (int i = 99; i > 0; i--)
{
    string numberAsText = i.ToString();

    if (numberAsText.Length > 1 && Int32.Parse((numberAsText[0].ToString())) + Int32.Parse((numberAsText[1].ToString())) == 10)
    {
        Console.WriteLine($"Match found for {numberAsText}: ({numberAsText[0]},{numberAsText[1]})");
    }
    else
    {
        noMatch += numberAsText + ',';
    }
}

Console.WriteLine("\nNo match found for:\n");
Console.WriteLine(noMatch.Substring(0, noMatch.Length - 1));

//Don't need tryParse because I am limiting the input to ints between 99 and 1
//short circuiting at the first expression in the if statement allows avoidance of System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'

//ToString().ToString()
//difficult for me not to include the type in the variable name 

//https://stackoverflow.com/questions/829174/is-there-an-easy-way-to-turn-an-int-into-an-array-of-ints-of-each-digit