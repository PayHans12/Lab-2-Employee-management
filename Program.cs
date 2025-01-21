using Employees;

FullTimeEmployee Steve = new FullTimeEmployee(1000.00m, 10000.00m);

PartTimeEmployee Fred = new PartTimeEmployee(10.00m, 160);

Console.WriteLine(Steve.CalculateSalary());
Console.WriteLine(Fred.CalculateSalary());

