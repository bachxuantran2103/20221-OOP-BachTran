using System;
using System.Text;
// Trần Xuân Bách 20206272
namespace _20206272_W1_3_Sum1_100
{
    class Program
    {
        static int Sum()
        {
            int x = 0;
            for(int i = 1; i <= 100; i++)
            {
                x = x + i;
            }
            return x;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Tổng từ 1 đến 100 là: {Sum()}");
        }
    }
}
