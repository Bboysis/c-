using System; 
abstract class Marks 
{ 
public abstract double getPercentage(); 
} 
class A : Marks 
{ 
private double m1, m2, m3; 
public A(double m1, double m2, double m3) 
{ 
this.m1 = m1; 
this.m2 = m2; 
this.m3 = m3; 
} 
public override double getPercentage() 
{ 
return (m1 + m2 + m3) / 300 * 100; 
} 
} 
class B : Marks 
{ 
private double m1, m2, m3, m4; 
public B(double m1, double m2, double m3, double m4) 
{ 
this.m1 = m1; 
this.m2 = m2; 
this.m3 = m3; 
this.m4 = m4; 
} 
public override double getPercentage() 
{ 
return (m1 + m2 + m3 + m4) / 400 * 100; 
} 
} 
class TestMarks 
{
static void Main() 
{ 
A studentA = new A(80, 79, 97); 
B studentB = new B(78, 89, 64, 78); 
Console.WriteLine("Student A percentage: {0:F2}%", 
studentA.getPercentage()); 
Console.WriteLine("Student B percentage: {0:F2}%", 
studentB.getPercentage()); 
} 
}