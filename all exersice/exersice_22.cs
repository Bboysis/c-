using System;

int[] numbers = { 22, 26, 14, 78, 78, 65, 65, 78, 22, 14, 22 };

for (int i = 0; i < numbers.Length; i++)
{
    bool alreadyCounted = false;

    for (int k = 0; k < i; k++)
    {
        if (numbers[i] == numbers[k])
        {
            alreadyCounted = true;
            break;
        }
    }
// yetedegagemutn mawtat
    if (!alreadyCounted)
    {
        int count = 0;

        for (int j = 0; j < numbers.Length; j++)
        {
            if (numbers[i] == numbers[j])
                count++;
        }

        Console.WriteLine(
            numbers[i] + " occurs " + count + " times");
    }
}