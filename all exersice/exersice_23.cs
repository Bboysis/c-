using System;

int[] numbers = { 12, 56, 8, 97, 14, 10 };

int maximum = numbers[0];
int minimum = numbers[0];

foreach (int number in numbers)
{
    if (number > maximum)
        maximum = number;

    if (number < minimum)
        minimum = number;
}

Console.WriteLine("Maximum element is: " + maximum);
Console.WriteLine("Minimum element is: " + minimum);