using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace _20206272_W5_2_AmountException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Trần Xuân Bách - 20206272
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            try
            {
                Student B = new Student("Bách", "Senior", 70000, 20000);
                Student A = new Student("Đức", "Senior", 50000, 5000);

                Console.WriteLine(AmountException.CheckIncome(A));
                Console.WriteLine(AmountException.CheckIncome(B));

                Console.WriteLine("\n" + A.GetType().Name);

                foreach (MemberInfo item in A.GetType().GetMembers())
                {
                    Console.WriteLine($"{item.MemberType}: {item.Name}");
                }
            }
            catch(Exception E)
            {
                Console.WriteLine(E.Message);
            }

        }
    }
    

    

}
