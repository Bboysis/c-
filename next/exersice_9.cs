using System; 
class Month 
{ 
private int monthNumber; 
private static string[] names = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" }; 
private static int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }; 
public int MonthNumber 
{ 
get { return monthNumber; } 
set { monthNumber = value; } 
} 
public Month(int monthNumber) 
{
this.monthNumber = monthNumber; 
} 
public bool IsValid() 
{ 
return monthNumber >= 1 && monthNumber <= 12; 
} 
public string GetMonthName() 
{ 
return names[monthNumber - 1]; 
} 
public int GetDaysInMonth() 
{ 
return days[monthNumber - 1]; 
} 
public string DisplayDetail() 
{ 
return GetMonthName() + " has " + GetDaysInMonth() + " days"; 
} 
} 
class TestMonth 
{ 
static void Main() 
{ 
Console.Write("Enter a month number (1-12): "); 
int number = int.Parse(Console.ReadLine()); 
Month month = new Month(number); 
if (month.IsValid()) 
Console.WriteLine(month.DisplayDetail()); 
else 
Console.WriteLine("Invalid month number. Please enter a number from 1 to 12."); 
} 
}