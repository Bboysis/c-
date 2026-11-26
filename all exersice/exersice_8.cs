using System;

int sum = 0;

for (int i = 1; i <= 10; i++)
{
    sum += i;
}
//ke 1-10 yalutn no demro yaskemtal
Console.WriteLine("Sum = " + sum);
 

for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("* ");
    }

    Console.WriteLine();
}