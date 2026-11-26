using System; 
abstract class Shape 
{ 
protected double width; 
protected double height; 
public Shape(double width, double height) 
{ 
this.width = width; 
this.height = height; 
} 
public abstract double CalculateSurface(); 
} 
class Rectangle : Shape 
{ 
public Rectangle(double width, double height) : base(width, height) { } 
public override double CalculateSurface() 
{ 
return height * width; 
} 
} 
class Triangle : Shape 
{ 
public Triangle(double width, double height) : base(width, height) { } 
public override double CalculateSurface() 
{ 
return height * width / 2; 
} 
} 
class Circle2: Shape 
{
// width and height both hold the radius 
public Circle2(double radius) : base(radius, radius) { } 
public override double CalculateSurface() 
{ 
return Math.PI * width * height; 
} 
} 
class TestShapes 
{ 
static void Main() 
{ 
Shape[] shapes = { new Rectangle(4, 5), new Triangle(3, 5), new Circle2(6) }; //retangle and triangle,circle
string[] names = { "Rectangle", "Triangle", "Circle" }; 
for (int i = 0; i < shapes.Length; i++) 
Console.WriteLine(names[i] + " area: {0:F2}", 
shapes[i].CalculateSurface()); 
} 
}