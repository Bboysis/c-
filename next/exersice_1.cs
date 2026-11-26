using System; 

class House 
{ 

         private double length; 
         private double width; 
         private double area; 

public House(double length, double width) 
{ 
            this.length = length; 
            this.width = width; 
            this.area = length * width; 
} 
public void ShowData() 
{ 
            Console.WriteLine("the area is " + area + " m2"); 
            } 
} 
class TestClass 
{ 
    static void Main() 
{ 
       Console.Write("Enter the length of the house: "); 
       double length = double.Parse(Console.ReadLine()); 
       Console.Write("Enter the width of the house: "); 
       double width = double.Parse(Console.ReadLine()); 

       House house = new House(length, width); 
       house.ShowData(); 
} 
}