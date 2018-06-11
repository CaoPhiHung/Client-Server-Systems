using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeTest
{
    class Employee
    {
        private String firstname;
        private String lastname;
        private decimal salary;

        public Employee(String firstname, String lastname, decimal salary)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.salary = salary;
        }

        public String getFirstname()
        {
            return this.firstname;
        }

        public void setFirstname(String firstname)
        {
            this.firstname = firstname;
        }

        public String getLastname()
        {
            return this.lastname;
        }

        public void setLastname(String lastname)
        {
            this.lastname = lastname;
        }

        public Decimal getSalary()
        {
            return this.salary;
        }

        public void setSalary(decimal salary)
        {
            this.salary = salary;
        }

        public decimal getYearlySalary()
        {
            return this.salary * 12;
        }

        public void increaseSalary(int percent)
        {
            this.salary = this.salary + this.salary * percent / 100;
        }

        public void toString()
        {
            Console.WriteLine(this.getFirstname()
                + " " + this.getLastname() + " ; Yearly Salary: $" + this.getYearlySalary());
        }
    }
}
