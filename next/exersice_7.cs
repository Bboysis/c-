using System; 
class Program7 
{ 
private double length; 
private double width; 
public Program7(double length, double width) 
{ 
this.length = length; 
this.width = width; 
} 
public double caculateArea() 
{ 
return length * width; 
} 
public double getLength() { return length; } 
public double getWidth() { return width; } 
public void setLength(double length) { this.length = length; } 
public void setWidth(double width) { this.width = width; } 
} 
class TestProgram7 
{ 
static void Main() 
{ 
Console.Write("Enter the length of the rectangle: "); 
double l = double.Parse(Console.ReadLine()); 
Console.Write("Enter the width of the rectangle: "); 
double w = double.Parse(Console.ReadLine()); 
Program7 rect = new Program7(l, w); 
Console.WriteLine(new string('*', 70)); 
Console.WriteLine("The length of the rectangle is: " + 
rect.getLength()); 
Console.WriteLine("The width of the rectangle is: " + 
rect.getWidth()); 
Console.WriteLine("The area of the rectangle is: " + 
rect.caculateArea()); 
} 
}