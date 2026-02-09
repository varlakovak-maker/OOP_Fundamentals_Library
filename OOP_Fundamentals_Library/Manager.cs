using System;
using System.Collections.Generic;

namespace OOP_Fundamentals_Library
{
    public class Manager : Employee
    {
        public string Department { get; set; }

        // Инкапсуляция списка команды
        private readonly List<Employee> _team = new();
        public IReadOnlyCollection<Employee> Team => _team.AsReadOnly();

        public override void PrintInfo()
        {
            Console.WriteLine($"Manager: {Name}, Age: {Age}, Dept: {Department}, Team Size: {Team.Count}");
        }

        public void AddTeamMember(Employee emp)
        {
            if (emp != null) _team.Add(emp);
        }

        public void AssignTaskToEmployee(Employee emp, string task)
        {
            Console.WriteLine($"Manager {Name} assigning task '{task}' to {emp.Name}");
        }

        public override void ProcessPayroll()
        {
            Console.WriteLine($"Processing payroll for Manager {Name} (Dept: {Department}): {Salary}");
        }
    }
}