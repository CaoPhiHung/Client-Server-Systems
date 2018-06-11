using System;

namespace EmployeeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //create employee
            Employee emp1 = new Employee("Bob", "Jones", 5000);
            Employee emp2 = new Employee("Susan", "Baker", 4500);

            //display employee
            Console.Write("Employee 1:");
            emp1.toString();
            Console.Write("Employee 2:");
            emp2.toString();

            //increase employee salaries by 10%
            Console.WriteLine("\nIncreasing employee salaries by 10%");
            emp1.increaseSalary(10);
            emp2.increaseSalary(10);

            Console.Write("Employee 1:");
            emp1.toString();
            Console.Write("Employee 2:");
            emp2.toString();

            Console.ReadLine();

        }
    }
}
