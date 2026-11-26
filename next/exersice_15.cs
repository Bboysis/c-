 using System;

abstract class StaffEmployee
{
    public string Name { get; set; } = "";
    public double BaseSalary { get; set; }

    public StaffEmployee(string name, double baseSalary)
    {
        Name = name;
        BaseSalary = baseSalary;
    }

    public abstract double calculateSalary();
    public abstract void displayInfo();
}

class StaffManager : StaffEmployee
{
    private double bonus;

    public double Bonus
    {
        get { return bonus; }
        set { bonus = value; }
    }

    public StaffManager(string name, double baseSalary, double bonus)
        : base(name, baseSalary)
    {
        this.bonus = bonus;
    }

    public override double calculateSalary()
    {
        return BaseSalary + bonus;
    }

    public override void displayInfo()
    {
        Console.WriteLine("Manager: " + Name);
        Console.WriteLine("Base salary: " + BaseSalary + ", bonus: " + bonus);
        Console.WriteLine("Total salary: " + calculateSalary());
    }
}

class StaffProgrammer : StaffEmployee
{
    private double overtimeHours;
    private double hourlyRate;

    public double OvertimeHours
    {
        get { return overtimeHours; }
        set { overtimeHours = value; }
    }

    public double HourlyRate
    {
        get { return hourlyRate; }
        set { hourlyRate = value; }
    }

    public StaffProgrammer(string name, double baseSalary, double overtimeHours, double hourlyRate)
        : base(name, baseSalary)
    {
        this.overtimeHours = overtimeHours;
        this.hourlyRate = hourlyRate;
    }

    public override double calculateSalary()
    {
        return BaseSalary + overtimeHours * hourlyRate;
    }

    public override void displayInfo()
    {
        Console.WriteLine("Programmer: " + Name);
        Console.WriteLine("Base salary: " + BaseSalary + ", overtime hours: " + overtimeHours + ", hourly rate: " + hourlyRate);
        Console.WriteLine("Total salary: " + calculateSalary());
    }
}

class TestStaff
{
    static void Main()
    {
        StaffEmployee[] employees =
        {
            new StaffManager("Sara Tesfaye", 30000, 5000),
            new StaffProgrammer("Abebe Kebede", 15000, 10, 200)
        };

        foreach (StaffEmployee e in employees)
        {
            e.displayInfo();
            Console.WriteLine();
        }
    }
}