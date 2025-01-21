namespace Employees;

public class Employee
{
    
    public string Name {get; set;}
    public Guid EmployeeId {get; private set;}
    public decimal BaseSalary {get; private set;}
    
    public Employee()
    {
        EmployeeId = Guid.newGuid();
    }

    public Employee(string name, decimal baseSalary, Guid employeeId)
    {
        Name = name;
        EmployeeId = employeeId;
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