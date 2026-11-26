using System;
using System.Globalization;

Console.Write("Input the string: ");
string input = Console.ReadLine()!;

TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

string result = textInfo.ToTitleCase(input.ToLower());
//first letter  capital madreg
Console.WriteLine("Input with first letter uppercase: " + result);