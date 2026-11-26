using System;

Console.Write("Input a number: ");
int number = int.Parse(Console.ReadLine()!);

int temp = Math.Abs(number);
int product = 1;

if (temp == 0)
{
    product = 0;
}

while (temp > 0)
{
    int digit = temp % 10;
    product *= digit;
    temp /= 10;
}

Console.WriteLine(
    "The product " + number + " is: " + product);