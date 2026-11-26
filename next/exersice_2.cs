using System; 
class Person 
{ 
     private string name; 
     private int age; 
public Person(string name, int age) 
{ 
this.name = name; 
this.age = age; 
} 
public void PrintData() 
{ 
Console.WriteLine("Name: " + name + " and Age: " + age); 
} 
} 
class TestClass2 
{ 
static void Main() 
{ 
Person p1 = new Person("sisay", 23); 
Person p2 = new Person("beti", 22); 
Person p3 = new Person("abebe", 34);
p1.PrintData(); 
p2.PrintData(); 
p3.PrintData();
} 
}