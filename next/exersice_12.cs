using System; 
class Member 
{ 
public string Name { get; set; } 
public int Age { get; set; } 
public string PhoneNumber { get; set; } 
public string Address { get; set; } 
public double Salary { get; set; } 
public void PrintSalary() 
{ 
Console.WriteLine("Salary: " + Salary); 
} 
public virtual void PrintDetails() 
{ 
Console.WriteLine("Name: " + Name); 
Console.WriteLine("Age: " + Age); 
Console.WriteLine("Phone number: " + PhoneNumber); 
Console.WriteLine("Address: " + Address); 
PrintSalary(); 
} 
} 
class Employee : Member 
{
public string Specialization { get; set; } 
public override void PrintDetails() 
{ 
base.PrintDetails(); 
Console.WriteLine("Specialization: " + Specialization); 
} 
} 
class Manager : Member 
{ 
public string Department { get; set; } 
public override void PrintDetails() 
{ 
base.PrintDetails(); 
Console.WriteLine("Department: " + Department); 
} 
} 
class TestMember 
{ 
static void Main() 
{ 
Employee emp = new Employee(); 
emp.Name = "Abebe Kebede"; 
emp.Age = 28; 
emp.PhoneNumber = "0911000000"; 
emp.Address = "Addis Ababa"; 
emp.Salary = 15000; 
emp.Specialization = "Software Development"; 
Manager mgr = new Manager(); 
mgr.Name = "Sara Tesfaye"; 
mgr.Age = 40; 
mgr.PhoneNumber = "0922000000"; 
mgr.Address = "Adama"; 
mgr.Salary = 30000; 
mgr.Department = "IT"; 
Console.WriteLine("--- Employee ---"); 
emp.PrintDetails(); 
Console.WriteLine(); 
Console.WriteLine("--- Manager ---"); 
mgr.PrintDetails(); 
} 
}