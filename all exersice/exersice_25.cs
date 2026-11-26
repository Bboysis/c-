using System;

int[] numbers = { 12, 3, 5, 11 };

Array.Sort(numbers);

int largest = numbers[numbers.Length - 1];
int secondLargest = 0;

for (int i = numbers.Length - 2; i >= 0; i--)
{
    if (numbers[i] < largest)
    {
        secondLargest = numbers[i];
        break;
    }
}
//secode large number print
Console.WriteLine("Second largest element: " + secondLargest);