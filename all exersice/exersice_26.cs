using System;

Console.Write("Input the string: ");
string input = Console.ReadLine()!;

int count = 0;
bool insideWord = false;

foreach (char ch in input)
{
    if (char.IsWhiteSpace(ch))
    {
        insideWord = false;
    }
    else if (!insideWord)
    {
        count++;
        insideWord = true;
    }
}
//count character
Console.WriteLine(
    "Total number of words in the string is: " + count);