using System;
Console.Write("Enter x: ");
int x = int.Parse(Console.ReadLine());
//add and print tiandle digona;
Console.Write("Enter y: ");
int y = int.Parse(Console.ReadLine());
 if (x > y)
{
    int temp = x;
    x = y;
    y = temp;
}
int sum = 0;

for (int i = x; i <= y; i++)
{
    sum += i;
}

Console.WriteLine("Sum is = " + x + "+" + y + "=" + sum);

for (int row = 1; row <= 5; row++)
{
    for (int s = 0; s <= 5 - row; s++)
        Console.Write(" ");
    for (int k = 0; k < row; k++)
        Console.Write("* ");
    Console.WriteLine();
    {
        
    }

    
}