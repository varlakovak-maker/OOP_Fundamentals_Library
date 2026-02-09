using System;

namespace OOP_Fundamentals_Library
{
    public class PayrollSystem
    {
        // Полиморфизм: работает и с Employee, и с Manager через одного родителя
        public void ProcessSalary(Employee emp)
        {
            emp.ProcessPayroll();
        }
    }
}