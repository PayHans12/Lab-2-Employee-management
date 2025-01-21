namespace Employees;

public class Employee
{
    Random num = new Random();
    public string Name {get; set;}
    public int EmployeeId {get; private set;}
    public decimal BaseSalary {get; private set;}
    
    public Employee()
    {
        EmployeeId = num.Next();
        BaseSalary = 10000 * (decimal)num.NextDouble();
        Name = "Unknown";
    }

    public Employee(string name, decimal baseSalary)
    {
        Name = name;
        EmployeeId = num.Next();
        BaseSalary = baseSalary;
    }

    public decimal CalculateSalary()
    {
        return BaseSalary;
    }
}

public class FullTimeEmployee:Employee
{
    public decimal AnnualBonus {get; private set;}

    public FullTimeEmployee()
    {
        
    }
    public FullTimeEmployee(decimal annualBonus)
    {
        AnnualBonus = annualBonus;
    }

    public decimal CalculateSalary()
    {
        return BaseSalary + AnnualBonus;
    }
}

public class PartTimeEmployee:Employee
{
    public decimal HourlyRate {get; private set;}
    public int HoursWorked {get; private set;}

    public PartTimeEmployee()
    {
 
    }

    public PartTimeEmployee(decimal hourlyRate, int hoursWorked)
    {
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }

    public decimal CalculateSalary()
    {
        return HourlyRate * HoursWorked;
    }
}