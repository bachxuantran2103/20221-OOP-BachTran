using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace _20206272_W3_2_Person_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            //Trần Xuân Bách - 20206272
            try
            {
                Console.WriteLine("Enter name, phone number, email address");
                string[] PerData = new string[3] { Console.ReadLine(), Console.ReadLine(), Console.ReadLine() };
                Console.WriteLine("1. Student \n2. Employee");
                int key = int.Parse(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("Enter majors: ");
                        Student A = new Student(PerData[0], PerData[1], PerData[2], Console.ReadLine());
                        Console.WriteLine($"{A.ToString()} \nMajors: {A.majors}" );
                        break;
                    case 2:
                        Console.WriteLine("Enter department, salary, hired date (MM/DD/YYYY), title");
                        string[] EmpData = new string[4] { Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine() };
                        Employee B = new Faculty();

                        Console.WriteLine("1. Faculty \n2. Staff");
                        key = int.Parse(Console.ReadLine());
                        switch (key)
                        {
                            case 1:
                                Console.WriteLine("Enter office hours and rank: ");
                                B = new Faculty(EmpData[0], double.Parse(EmpData[1]), DateTime.Parse(EmpData[2]), EmpData[3], double.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                                B.name = PerData[0]; B.phoneNumber = PerData[1]; B.email = PerData[2];
                                Console.WriteLine(B.ToString());
                                Console.WriteLine($"Bonus: {B.CalculateBonus()} ; Vacation: {B.CalculateVacation()}");
                                break;
                            case 2:
                                B = new Staff(EmpData[0], double.Parse(EmpData[1]), DateTime.Parse(EmpData[2]), EmpData[3]);
                                B.name = PerData[0]; B.phoneNumber = PerData[1]; B.email = PerData[2];
                                Console.WriteLine(B.ToString());
                                Console.WriteLine($"Bonus: {B.CalculateBonus()} ; Vacation: {B.CalculateVacation()}");
                                break;
                        }
                        break;

                }
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }
    }
    
}
