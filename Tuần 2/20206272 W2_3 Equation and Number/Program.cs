using System;
using System.Text;
using _20206272_W2_3_Equation_and_Number;
namespace _20206272_W2_3_Equation_and_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Trần Xuân Bách - 20206272
            //Console.WriteLine(new Complex(Console.ReadLine()).ToString());
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập bậc của phương trình: ");
            bool rankcheck = true;
            int rank = 0;
            do
            {
                if(int.TryParse(Console.ReadLine(), out rank))
                {
                    rankcheck = false;
                }
                else
                {
                    Console.WriteLine("Nhập lại bậc của phương trình: ");
                }
            }
            while(rankcheck );

            if(rank == 1)
            {
                Console.WriteLine("Nhập lần lượt 2 hệ số của a*x + b = 0 : ");
                double a = 0, b = 0;
                string c, d;
                c = Console.ReadLine();
                d = Console.ReadLine();
                if (double.TryParse(c, out a) && double.TryParse(d, out b))
                {
                    Equation.FirstEqR(a, b);
                }
                else Equation.FirstEqC(new Complex(c),new Complex(d));

            }
            if(rank == 2)
            {
                Console.WriteLine("Nhập lần lượt 3 hệ số của a*x^2 + b*x + c = 0 : ");
                double a = 0, b = 0, c=0;
                string d,e,f;
                d = Console.ReadLine();
                e = Console.ReadLine();
                f = Console.ReadLine();
                if (double.TryParse(d, out a) && double.TryParse(e, out b) && double.TryParse(f, out c))
                {
                    Equation.QuadraticR(a, b, c);
                }
                else Equation.QuadraticC(new Complex(d), new Complex(e), new Complex(f));
            }
        }
    }
    
}
