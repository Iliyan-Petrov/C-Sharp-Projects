using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public string Department { get; set; }
}

class CompanyRoster
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<Employee> employees = new List<Employee>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            string name = input[0];
            decimal salary = decimal.Parse(input[1]);
            string department = input[2];

            Employee employee = new Employee
            {
                Name = name,
                Salary = salary,
                Department = department
            };

            employees.Add(employee);
        }

        var departmentAverageSalaries = employees
            .GroupBy(e => e.Department)
            .ToDictionary(g => g.Key, g => g.Average(e => e.Salary));

        string highestAverageSalaryDepartment = departmentAverageSalaries
            .OrderByDescending(kv => kv.Value)
            .First()
            .Key;

        var filteredEmployees = employees
            .Where(e => e.Department == highestAverageSalaryDepartment)
            .OrderByDescending(e => e.Salary);

        Console.WriteLine($"Highest Average Salary: {highestAverageSalaryDepartment}");

        foreach (var employee in filteredEmployees)
        {
            Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
        }
    }
}
