using System; 
class Program6 
{ 
private int number1; 
private int number2; 
private int number3; 
public Program6(int number1, int number2, int number3) 
{ 
this.number1 = number1; 
this.number2 = number2; 
this.number3 = number3; 
} 
//last digit yayna ke 3tu 2tu the same kehone print true
public bool checkRigtmostDigit() 
{ 
int d1 = number1 % 10; 
int d2 = number2 % 10; 
int d3 = number3 % 10; 
return d1 == d2 || d1 == d3 || d2 == d3; 
} 
} 
class TestProgram6 
{ 
static void Main() 
{ 
Console.Write("Enter the first number: "); 
int a = int.Parse(Console.ReadLine()); 
Console.Write("Enter the second number: "); 
int b = int.Parse(Console.ReadLine()); 
Console.Write("Enter the third number: "); 
int c = int.Parse(Console.ReadLine()); 
Program6 p = new Program6(a, b, c); 
Console.WriteLine(p.checkRigtmostDigit()); 
} 
}