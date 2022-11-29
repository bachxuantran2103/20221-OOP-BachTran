using _20206272_W4_4_Complex_Number;
using System;
using System.Text;

namespace _20206272_W4_5_Polynomial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Trần Xuân Bách - 20206272
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Polynomial A = new Polynomial(2);
            A[0] = new ComplexNumbers(2, 0);
            A[1] = new ComplexNumbers(3, 0);
            A[2] = new ComplexNumbers(4, 0);
            Console.WriteLine(A.ToString());
            Console.WriteLine("Với X = 3+5i, F = " + A.CalculateValue(new ComplexNumbers(3, 5)).ToString());
            Console.WriteLine("Đạo hàm: "+A.Derivative().ToString());
            Console.WriteLine("Nguyên hàm: " + A.Primitive().ToString());
            Polynomial B = new Polynomial(4);
            B = A * A;
            Console.WriteLine("Bình phương của hàm: "+ (B).ToString());
            Console.WriteLine($"Phương trình có nghiệm: {A.Solve()[0]} và {A.Solve()[1]}");
            

        }
    }
}
