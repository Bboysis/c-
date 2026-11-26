 using System;

class Human
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";

    public Human() { }

    public Human(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

class HumanStudent : Human
{
    public int Mark { get; set; }

    public HumanStudent(string firstName, string lastName, int mark)
        : base(firstName, lastName)
    {
        Mark = mark;
    }
}

class HumanWorker : Human
{
    public double Wage { get; set; }
    public double HoursWorked { get; set; }

    public HumanWorker(string firstName, string lastName, double wage, double hoursWorked)
        : base(firstName, lastName)
    {
        Wage = wage;
        HoursWorked = hoursWorked;
    }

    public double CalculateHourlyWage()
    {
        if (HoursWorked == 0) return 0;
        return Wage / HoursWorked;
    }
}

class TestHuman
{
    static void Main()
    {
        HumanStudent student = new HumanStudent("yonas", "senay", 85);
        HumanWorker worker = new HumanWorker("sarim", "Tesfaye", 8000, 160);

        Console.WriteLine("Student: " + student.FirstName + " " + student.LastName + ", mark: " + student.Mark);
        Console.WriteLine("Worker: " + worker.FirstName + " " + worker.LastName);
        Console.WriteLine("Hourly wage: " + worker.CalculateHourlyWage());
    }
}