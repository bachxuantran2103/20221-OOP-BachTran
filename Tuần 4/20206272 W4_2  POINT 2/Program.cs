using System;
using System.Text;

namespace _20206272_W4_2__POINT_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Trần Xuân Bách - 20206272
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            try
            {
                Point A = new Point(1, 1);
                Point B = new Point(3, 4);
                Console.WriteLine($"A{A.ToString()}\nB{B.ToString()}");

                Console.WriteLine($"C đối xứng A qua Oy: C({A.GetSymmetricYaxis().ToString()})");
                Console.WriteLine($"D đối xứng A qua Ox: D({A.GetSymmetricXaxis().ToString()})");
                Console.WriteLine($"E đối xứng A qua B: E({A.GetSymmetricP(B).ToString()})");
                Console.WriteLine($"A + B = {(A + B).ToString()}");
                Console.WriteLine($"A - B = {(A - B).ToString()}");
                Console.WriteLine($"A * B = {(A * B).ToString()}");
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }

        }
    }
}
