using System;

namespace OOP_Fundamentals_Library
{
    // Абстрактный базовый класс
    public abstract class Person
    {
        private string _name;
        private int _age;

        public string Name
        {
            get => _name;
            set => _name = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Имя не может быть пустым");
        }

        public int Age
        {
            get => _age;
            set => _age = value > 0 ? value : throw new ArgumentException("Возраст должен быть положительным");
        }

        public abstract void PrintInfo();
    }

    public class Employee : Person
    {
        private decimal _salary;
        public string Position { get; set; }

        public decimal Salary
        {
            get => _salary;
            protected set => _salary = value >= 0 ? value : throw new ArgumentException("Зарплата не может быть отрицательной");
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Employee: {Name}, Age: {Age}, Position: {Position}");
        }

        public virtual void IncreaseSalary(decimal amount)
        {
            if (amount > 0) Salary += amount;
        }

        public virtual void ProcessPayroll()
        {
            Console.WriteLine($"Processing payroll for {Name}: {Salary}");
        }
    }
}