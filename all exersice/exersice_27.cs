 using System;

Console.Write("Input the string: ");
string input = Console.ReadLine()!;

string result = "";

foreach (char ch in input)
{
    if (!char.IsWhiteSpace(ch))
        result += ch;
}

Console.Write("The characters is reverse are: ");

for (int i = result.Length - 1; i >= 0; i--)
{
    Console.Write(result[i]);

    if (i > 0)
        Console.Write(" ");
}
//reverce reding
Console.WriteLine();