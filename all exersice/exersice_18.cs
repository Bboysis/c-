using System;

Console.Write("Enter the number: ");
int number = int.Parse(Console.ReadLine()!);

int lastDigit = number % 10;
int firstDigit = number;

while (firstDigit >= 10)
{
    firstDigit /= 10;
}

Console.WriteLine("The first digit is: " + firstDigit);
Console.WriteLine("The last digit is: " + lastDigit);
