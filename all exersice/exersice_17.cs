using System;

int DigitsSum(int number)
{
    int sum = 0;

    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }

    return sum;
}

Console.WriteLine(DigitsSum(5034));
Console.WriteLine(DigitsSum(904860));
 //ad dinput nu