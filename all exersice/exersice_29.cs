using System;
//palindrome

Console.Write("Enter a string: ");
string input = Console.ReadLine()!;

string cleaned = "";

foreach (char ch in input)
{
    if (char.IsLetterOrDigit(ch))
    {
        cleaned += char.ToLowerInvariant(ch);
    }
}
//sigelebet erasun charcter keseten 
bool isPalindrome = true;

int left = 0;
int right = cleaned.Length - 1;

while (left < right)
{
    if (cleaned[left] != cleaned[right])
    {
        isPalindrome = false;
        break;
    }

    left++;
    right--;
}

if (isPalindrome)
    Console.WriteLine("The string is a palindrome.");
else
    Console.WriteLine("The string is not a palindrome.");