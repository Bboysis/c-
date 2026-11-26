using System;

bool IfSortedAscending(int[] numbers)
{
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        if (numbers[i] > numbers[i + 1])
            return false;
    }

    return true;
}

Console.WriteLine(
    IfSortedAscending(new int[] { 0, 3, 7, 10 }));
// ketnsu wede tlku mederder
Console.WriteLine(
    IfSortedAscending(new int[] { 74, 62, 99 }));