using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInheritance;

Employee bob = new Employee("Rob", 40, 20);
//Console.WriteLine(bob);
//Console.WriteLine(bob.CalculatePay().ToString("c"));

Employee ann = new Employee("Ann", 30, 25);
//Console.WriteLine(ann);
//Console.WriteLine(ann.CalculatePay().ToString("c"));

PermanentEmployee chris = new PermanentEmployee("Chris", 30, 25, 0.1m);
//Console.WriteLine(chris);
//Console.WriteLine(chris.CalculatePay().ToString("c"));
//Console.WriteLine($"Deducted RRSP: {chris.CalculateRrsp():c}");

// I want to calculate total payroll - use the concept of polymorphism
List<Employee> employees = new List<Employee>();
employees.Add(bob);
employees.Add(ann);
employees.Add(chris);
employees.Add(new PermanentEmployee("Derek", 50, 20, 0.15m));

decimal totalPayRoll = 0m;

foreach (Employee emp in employees)
{
    totalPayRoll += emp.CalculatePay();
    Console.WriteLine($"{emp}, {emp.CalculatePay():c}");
    Console.WriteLine($"Current payroll: {totalPayRoll.ToString("c")} \n");
}

Console.WriteLine($"Total payroll: {totalPayRoll.ToString("c")} \n");