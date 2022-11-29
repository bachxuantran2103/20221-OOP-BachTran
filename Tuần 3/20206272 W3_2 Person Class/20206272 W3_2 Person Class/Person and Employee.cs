using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20206272_W3_2_Person_Class
{
    abstract class Person
    {
        public string name { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} {this.name} {this.email}";
        }
    }
    class Student : Person
    {
        public string majors { get; set; }

        public Student() { }
        public Student(string name, string phoneNumber, string email, string majors)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.majors = majors;
        }
        public string getMajors()
        {
            return this.majors;
        }
    }
    abstract class Employee : Person
    {
        public string department { get; set; }
        public double salary { get; set; }
        public DateTime hired { get; set; } // MM/DD/YYYY
        public string title { get; set; }

        public Employee() { }
        public Employee(string department, double salary, DateTime hired, string title)
        {
            this.department = department;
            this.salary = salary;
            this.hired = hired;
            this.title = title;
        }
        public abstract double CalculateBonus();
        public abstract string CalculateVacation();

    }
    class Faculty : Employee
    {
        public double officeHours;
        public int rank;

        public Faculty() { }
        public Faculty(string department, double salary, DateTime hired, string title, double officeHours, int rank) : base(department, salary, hired, title)
        {
            this.department = department;
            this.salary = salary;
            this.hired = hired;
            this.title = title;
            this.officeHours = officeHours;
            this.rank = rank;
        }

        public override double CalculateBonus()
        {
            return 1000 + 0.05 * this.salary;
        }
        public override string CalculateVacation()
        {
            int weeksOff;
            int workday = int.Parse((this.hired - DateTime.Now).Days.ToString());
            if (workday > (365 * 3)) weeksOff = 5;
            else weeksOff = 4;
            if (this.title.ToLower() == "senior lecturer") weeksOff++;
            return $"{weeksOff} weeks";
        }
    }
    class Staff : Employee
    {
        public Staff() { }
        public Staff(string department, double salary, DateTime hired, string title) : base(department, salary, hired, title)
        {
            this.department = department;
            this.salary = salary;
            this.hired = hired;
            this.title = title;
        }
        public override double CalculateBonus()
        {
            return 0.06 * this.salary;
        }
        public override string CalculateVacation()
        {
            int weeksOff;
            int workday = int.Parse((this.hired - DateTime.Now).Days.ToString());
            if (workday > (365 * 5)) weeksOff = 4;
            else weeksOff = 3;
            return $"{weeksOff} weeks";
        }

    }


}
