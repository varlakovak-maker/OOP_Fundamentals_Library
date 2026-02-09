using System;
using OOP_Fundamentals_Library;

namespace OOP_Fundamentals_Library
{
    internal class ProgramExample
    {
        static void Main(string[] args)
        {
            var customer = new Customer { Name = "John", Age = 30 };

            var employee = new Employee
            {
                Name = "Alice",
                Age = 25,
                Position = "Developer"
            };
            employee.IncreaseSalary(50000);

            var manager = new Manager
            {
                Name = "Bob",
                Age = 40,
                Department = "IT"
            };
            manager.IncreaseSalary(80000);
            manager.AddTeamMember(employee);

            // Демонстрация
            customer.PrintInfo();
            employee.PrintInfo();
            manager.PrintInfo();

            var payroll = new PayrollSystem();
            payroll.ProcessSalary(employee);
            payroll.ProcessSalary(manager);

            Console.WriteLine("\nReports:");
            ReportService.GenerateReport(customer);
            ReportService.GenerateReport(employee);
            ReportService.GenerateReport(manager);
        }
    }
}