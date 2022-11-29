using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20206272_W5_2_AmountException
{
    public class Student
    {
        public string personName;
        public string title;
        public int salary;
        public int bonus;
        public Student(string personName, string title, int salary, int bonus)
        {
            this.personName = personName;
            this.title = title;
            this.salary = salary;
            this.bonus = bonus;
        }
    }
}
