using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20206272_W2_2_Employee
{
    class Employee
    {
        private string _firstName;
        private string _lastName;
        private string _address;
        private long _sin;
        private double _salary;

        public Employee(string firstName, string lastName, string address, long sin, double salary)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._address = address;
            this._sin = sin;
            this._salary = salary;
        }
        public Employee(object[] data)
        {
            this._firstName = data[0].ToString();
            this._lastName = data[1].ToString();
            this._address = data[2].ToString();
            long.TryParse(data[3].ToString(), out this._sin);
            double.TryParse(data[4].ToString(), out this._salary);
        }
        public double Bonus(double per)
        {
            return this._salary * per;
        }
        public override string ToString()
        {
            return $"{this._firstName} {this._lastName} live in {this._address}.\nThis month he/she got {this._sin} sins and his/her salary is {this._salary}";
        }
    }
}
