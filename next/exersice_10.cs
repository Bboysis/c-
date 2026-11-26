using System; 
class Student 
{ 
private static int count = 0; 
// properties encapsulate the data 
public string FullName { get; set; } 
public string Course { get; set; } 
public string Subject { get; set; } 
public string University { get; set; } 
public string Email { get; set; } 
public string Phone { get; set; } 
 public static int Count 
{ 
get { return count; } 
} 
public Student(string fullName, string course, string subject, 
string university, string email, string phone) 
{ 
FullName = fullName; 
Course = course; 
Subject = subject; 
University = university; 
Email = email; 
Phone = phone; 
count++; 
} 
public Student(string fullName, string course, string subject, string 
university) 
: this(fullName, course, subject, university, "", "") { } 
public Student(string fullName, string email) 
: this(fullName, "", "", "", email, "") { } 
public Student(string fullName) 
: this(fullName, "", "", "", "", "") { }
private static string Show(string value) 
{ 
return string.IsNullOrEmpty(value) ? "(not provided)" : value; 
} 
public void DisplayInfo() 
{ 
Console.WriteLine("Full name: " + Show(FullName)); 
Console.WriteLine("Course: " + Show(Course)); 
Console.WriteLine("Subject: " + Show(Subject)); 
Console.WriteLine("University: " + Show(University)); 
Console.WriteLine("E-mail: " + Show(Email)); 
Console.WriteLine("Phone: " + Show(Phone)); 
Console.WriteLine(); 
} 
} 
class StudentTest 
{ 
static void Main() 
{ 
Student s1 = new Student("sisay abebayew", "Computer Science", "java Programming", "unity University", "sisay@gmail.com", "091123456"); 
Student s2 = new Student("senay abebe", "software enginner", "c# Programming", "unity University", "ssenay@gmail.com", "091123456"); 
Student s3 = new Student("yonas kebede", "it department", "java script Programming", "arbamnch University", "yonas@gmail.com", "091123456"); 
Student s4 = new Student("samialberto", "Computer Science", "", "unity University", "sami@gmail.com", ""); 
s1.DisplayInfo(); 
s2.DisplayInfo(); 
s3.DisplayInfo(); 
s4.DisplayInfo(); 
Console.WriteLine("Number of Student objects created: " + 
Student.Count); 
} 
}