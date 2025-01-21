using Employees;

FullTimeEmployee Steve = new FullTimeEmployee(1000.00m);
Steve.Name = "Steve";

PartTimeEmployee Fred = new PartTimeEmployee(10.00m, 160);
Fred.Name = "Name";

Console.WriteLine(Steve.CalculateSalary());
Console.WriteLine(Fred.CalculateSalary());

