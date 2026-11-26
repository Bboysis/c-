using System; 
class Program8 
{ 
private int number1; 
private int number2; 
public Program8(int number1, int number2) 
{ 
this.number1 = number1; 
this.number2 = number2; 
} 
//le 100 krb yetu new 
public int checkNearest() 
{ 
int diff1 = Math.Abs(100 - number1); 
int diff2 = Math.Abs(100 - number2); 
if (diff1 == diff2) return 0; 
return diff1 < diff2 ? number1 : number2; 
} 
} 
class TestProgram8 
{ 
static void Main() 
{ 
Console.Write("Enter the first number: "); 
int a = int.Parse(Console.ReadLine()); 
Console.Write("Enter the second number: "); 
int b = int.Parse(Console.ReadLine()); 
Program8 p = new Program8(a, b); 
Console.WriteLine(p.checkNearest()); 
} 
}