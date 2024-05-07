using aaaaa;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();

        Manager manager = new Manager();
        manager.Name = "John Doe";
        manager.Salary = 50000;
        employees.Add(manager);

        Developer developer = new Developer();
        developer.Name = "Jane Smith";
        developer.Salary = 60000;
        employees.Add(developer);

        SalesPerson salesPerson = new SalesPerson();
        salesPerson.Name = "Bob Johnson";
        salesPerson.Salary = 40000;
        employees.Add(salesPerson);

        foreach (var employee in employees)
        {
            Console.WriteLine($"{employee.Name}: {employee.CalculateSalary()} SEK");
        }
    }
}
