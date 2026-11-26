using System;

int[] numbers = { 12, 5, 8, 7, 14, 10 };

int even = 0;
int odd = 0;

foreach (int number in numbers)
{
    if (number % 2 == 0)
        even++;
    else
        odd++;
}
//even odd count
Console.WriteLine("Even numbers: " + even);
Console.WriteLine("Odd numbers: " + odd);