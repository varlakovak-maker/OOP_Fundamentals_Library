using System;

namespace OOP_Fundamentals_Library
{
    public class ReportService
    {
        // Полиморфизм: один метод для всех Person (Employee, Manager, Customer)
        public static void GenerateReport(Person person)
        {
            Console.WriteLine($"--- Report for {person.GetType().Name} ---");
            person.PrintInfo();

            if (person is Employee emp)
            {
                Console.WriteLine($"  Salary Info: {emp.Salary}");
            }
            Console.WriteLine("--------------------------");
        }
    }
}