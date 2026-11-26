using System; 
class Circle 
{ 
private double radius; 
private string color; 
public Circle() 
{ 
radius = 1.0; 
color = "red"; 
}
//
public Circle(double radius) 
{ 
this.radius = radius; 
color = "red"; 
} 
public double getPerimeter() 
{ 
return 2 * Math.PI * radius; 
} 
public double getArea() 
{ 
return Math.PI * radius * radius; 
} 
} 
class TestCircle 
{ 
static void Main() 
{ 
Circle c1 = new Circle(); 
Circle c2 = new Circle(2.5); 
Console.WriteLine("Circle 1 (default): perimeter = {0:F2}, area = {1:F2}", c1.getPerimeter(), c1.getArea()); 
Console.WriteLine("Circle 2 (radius 2.5): perimeter = {0:F2}, area = {1:F2}", c2.getPerimeter(), c2.getArea()); 
} 
}