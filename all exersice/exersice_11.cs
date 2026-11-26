 using System;

Console.Write("Please enter the number of lines: ");
int n = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write($"{i * j,4}");
    }

    Console.WriteLine();
}