using System;
using System.Linq.Expressions;
using System.Text;

namespace _20206272_W2_4_perimeter_and_area
{
    internal class Program
    {
        // Trần Xuân Bách - 20206272
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            try
            {
                Console.WriteLine("Trần Xuân Bách - 20206272\nEnter \"exit\" to quit the program. ");
                string keys = "run";
                while (keys != "exit")
                {
                    Console.WriteLine("\nEnter shape: ");
                    keys = Console.ReadLine();
                    keys = keys.ToLower();
                    switch (keys)
                    {
                        case "circle":
                            Console.WriteLine("Enter radius: ");
                            double rad = double.Parse(Console.ReadLine());
                            Console.WriteLine($"Perimeter = {new Circle(rad).GetPerimeter()} ");
                            Console.WriteLine($"Area = {new Circle(rad).GetArea()} ");
                            break;
                        case "triagle":
                            Console.WriteLine("Enter 3 edges: ");
                            double a = double.Parse(Console.ReadLine());
                            double b = double.Parse(Console.ReadLine());
                            double c = double.Parse(Console.ReadLine());
                            Triagle A = new Triagle(a, b, c);
                            Console.WriteLine($"Perimeter = {A.GetPerimeter()} ");
                            Console.WriteLine($"Area = {A.GetArea()} ");
                            break;
                        case "rectangle":
                            Console.WriteLine("Enter long and width: ");
                            Rectangle B = new Rectangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                            Console.WriteLine($"Perimeter = {B.GetPerimeter()} ");
                            Console.WriteLine($"Area = {B.GetArea()} ");
                            break;
                        case "trapezoid":
                            Console.WriteLine("Enter in a row shortbase, longbase, leftleg and rightleg of the trapezoid: ");

                            double a1 = double.Parse(Console.ReadLine());
                            double b1 = double.Parse(Console.ReadLine());
                            double c1 = double.Parse(Console.ReadLine());
                            double d1 = double.Parse(Console.ReadLine());
                            Trapezoid D = new Trapezoid(a1, b1, c1, d1);
                            Console.WriteLine($"Perimeter = {D.GetPerimeter()} ");
                            Console.WriteLine($"Area = {D.GetArea()} ");
                            break;


                    }

                }
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }
    }
}
