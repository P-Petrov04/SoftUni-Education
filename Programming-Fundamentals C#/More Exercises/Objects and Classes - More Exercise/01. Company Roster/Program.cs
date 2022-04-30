using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Company_Roster
{
    class Employee
    {
        public Employee(string name, decimal salary, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Department = department;
        }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> allEmployees = new List<Employee>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] employeeArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = employeeArgs[0];
                decimal salary = decimal.Parse(employeeArgs[1]);
                string department = employeeArgs[2];

                Employee newEmployee = new Employee(name, salary, department);
                allEmployees.Add(newEmployee);
            }

            List<Employee> employeesWithHightestSalary = new List<Employee>();
            string departmentWithHightestSalary = string.Empty;
            decimal maxAverageSalary = 0;
            List<string> allDepartments = new List<string>();
            foreach (Employee employee in allEmployees)
            {
                string currentDepartment = employee.Department;
                if (!allDepartments.Contains(currentDepartment))
                {
                    allDepartments.Add(currentDepartment);
                }
            }

            foreach (string department in allDepartments)
            {
                List<Employee> employeesFromCurrDepartment = allEmployees.Where(e => e.Department == department).ToList();
                decimal salaries = 0;
                foreach (Employee employee in employeesFromCurrDepartment)
                {
                    salaries += employee.Salary;
                }
                decimal averageSalary = salaries / employeesFromCurrDepartment.Count;
                if (averageSalary > maxAverageSalary)
                {
                    maxAverageSalary = averageSalary;
                    departmentWithHightestSalary = department;
                    employeesWithHightestSalary = employeesFromCurrDepartment.OrderByDescending(e => e.Salary).ToList();
                }
            }

            Console.WriteLine($"Highest Average Salary: {departmentWithHightestSalary}");
            foreach (Employee employee in employeesWithHightestSalary)
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
            }
        }
    }
}
