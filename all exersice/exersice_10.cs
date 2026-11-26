using System;

Console.Write("Enter a positive number: ");
int num = int.Parse(Console.ReadLine()!);
//esketeseten kutr dres 2 add madreg 
int start = 0;

while (start < num)
{
    start += 2;

    if (start <= num)
    {
        Console.WriteLine(start);
    }
}