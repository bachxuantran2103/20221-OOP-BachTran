using System;
using System.Text;

namespace _20206272_W4_2_Points_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Trần Xuân Bách - 20206272
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            PointN A = new PointN(1, 3, 5, 7, 9);
            PointN B = new PointN(2, 4, 6, 8, 10);
            PointN C = new PointN(2, 3, 5, 7, 11, 13);
            Console.WriteLine($"Point A{A.ToString()}");
            Console.WriteLine($"Point B{B.ToString()}");
            Console.WriteLine($"Point C{C.ToString()}");
            Console.WriteLine($"A + B = {(A + B).ToString()}");
            Console.WriteLine($"A - B = {(A - B).ToString()}");
            Console.WriteLine($"C + A = {(A+C).ToString()}");
            Console.WriteLine($"Symmetric of A through dimmension 3: {A.GetSymmetric(3)}");
        }
    }
}
