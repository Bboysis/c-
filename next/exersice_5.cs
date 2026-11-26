using System; 
class Program5 
{ 
private int number1; 
private int number2; 
private int number3; 
//first number mestet alebacheww secind + third nu sidemeru
public Program5(int number1, int number2, int number3) 
{ 
this.number1 = number1; 
this.number2 = number2; 
this.number3 = number3; 
} 
public bool checkIfPossible() 
{ 
return number1 + number2 == number3 
|| number1 + number3 == number2 
|| number2 + number3 == number1; 
} 
} 
class TestProgram5 
{ 
static void Main() 
{ 
Console.Write("Enter the first number: "); 
int a = int.Parse(Console.ReadLine()); 
Console.Write("Enter the second number: "); 
int b = int.Parse(Console.ReadLine()); 
Console.Write("Enter the third number: "); 
int c = int.Parse(Console.ReadLine()); 
Program5 p = new Program5(a, b, c); 
Console.WriteLine(p.checkIfPossible()); 
} 
}