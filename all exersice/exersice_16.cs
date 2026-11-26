using System;

bool IfNumberContains3(int number)
{
    while (number > 0)
    {
        int digit = number % 10;//check 

        if (digit == 3)
            return true;

        number /= 10;//remove
    }

    return false;
}
// 3 detect madreg
Console.WriteLine(IfNumberContains3(7201432));
Console.WriteLine(IfNumberContains3(87501));