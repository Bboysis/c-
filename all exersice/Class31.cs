 using System;
class exersice_8
{
    static void Main()
    {
    
Console.Write("enter grade: ");
int grade = int.Parse(Console.ReadLine()!);
char gradeLetter;
if (grade >= 90 && grade < 101) 
           gradeLetter = 'A';
else if (grade >= 80)  
           gradeLetter = 'B';
else if (grade >= 70) 
            gradeLetter = 'C';
else if (grade >= 60) 
             gradeLetter = 'D';
else 
             gradeLetter = 'F';
Console.WriteLine("Letter grade: " + gradeLetter );
    }
}