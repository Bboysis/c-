using System;

int NumberOfEvenDigits(int number)
{
    int count = 0;

    while (number > 0)
    {
        int digit = number % 10;

        if (digit % 2 == 0)
            count++;

        number /= 10;
    }

    return count;
}
//even no print
Console.WriteLine(NumberOfEvenDigits(728832));
Console.WriteLine(NumberOfEvenDigits(9765221));