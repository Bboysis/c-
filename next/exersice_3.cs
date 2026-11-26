using System;
class Program3
{
// ke huletu no andu 5 or sum 5 kehone true
private int number1; 
private int number2; 
public Program3(int number1, int number2) 
{ 
this.number1 = number1; 
this.number2 = number2; 
} 
public bool checkIf5() 
{ 
return number1 == 5 || number2 == 5 
|| number1 + number2 == 5 
|| Math.Abs(number1 - number2) == 5; 
} 
} 
class TestProgram3 
{ 
static void Main() 
{ 
Console.Write("Enter the first number: "); 
int a = int.Parse(Console.ReadLine()); 
Console.Write("Enter the second number: "); 
int b = int.Parse(Console.ReadLine()); 
Program3 p = new Program3(a, b); 
Console.WriteLine(p.checkIf5()); 
} 
}