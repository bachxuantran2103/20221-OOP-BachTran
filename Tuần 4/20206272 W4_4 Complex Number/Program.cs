using System;
using System.Text;

namespace _20206272_W4_4_Complex_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Trần Xuân Bách - 20206272
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            ComplexNumbers X = new ComplexNumbers(7, -8);
            ComplexNumbers Y = new ComplexNumbers(-4, 11);
            Console.WriteLine($"X = {X.ToString()}\tY = {Y.ToString()}");
            Console.WriteLine($"X + Y = {(X + Y).ToString()}\tX - Y = {(X-Y).ToString()}");
            Console.WriteLine($"X * Y = {(X * Y).ToString()}\tX / Y = {(X / Y).ToString()}");
            Console.WriteLine($"Square(X) = {X.SqrtC()}\tX^2 = {(X ^ 2).ToString()}");

        }
    }
}
