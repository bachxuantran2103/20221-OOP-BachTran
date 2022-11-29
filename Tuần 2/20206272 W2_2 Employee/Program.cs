using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace _20206272_W2_2_Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Trần Xuân Bách - 20206272
            try
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Trần Xuân Bách - 20206272\nEnter first name, last name, address, sin, salary in a row");
                object[] data = new object[5];
                for (int i = 0; i < 5; i++)
                {
                    data[i] = Console.ReadLine();
                }
                Employee A = new Employee(data);
                Console.WriteLine(A.ToString());
                Console.WriteLine("Enter percentage: ");
                double per = double.Parse(Console.ReadLine());
                Console.WriteLine($"Bonus: {A.Bonus(per)}");
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }
        
    }
}
