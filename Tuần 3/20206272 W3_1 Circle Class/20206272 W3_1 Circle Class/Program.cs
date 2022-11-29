using System;
using System.Text;

namespace _20206272_W3_1_Circle_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            try
            {
                Console.WriteLine("Enter radius, color, weight in a row.");
                string[] input = new string[3];
                bool check = true;
                do
                {
                    input[0] = Console.ReadLine();
                    input[1] = Console.ReadLine();
                    input[2] = Console.ReadLine();
                    double rad = 0, wei = 0;
                    if (double.TryParse(input[0], out rad) && double.TryParse(input[2], out wei))
                    {
                        GeometricObject Cir = new Circle(rad, input[1], wei);
                        Console.WriteLine(Cir.ToString());
                        Console.WriteLine($"Perimeter = {Cir.findPerimeter()}; Area = {Cir.findArea()} ");
                        check = false;
                    }
                    else
                    {
                        Console.WriteLine("Enter radius, color, weight in a row again.");
                    }
                }
                while (check);
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }
    }
}
