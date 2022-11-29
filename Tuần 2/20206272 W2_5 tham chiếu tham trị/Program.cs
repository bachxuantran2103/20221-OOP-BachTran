using System;
using System.Text;

namespace _20206272_W2_5_tham_chiếu_tham_trị
{
    internal class Program
    {
        static void SwapValue( double a, double b)
        {
            double temp = a;
            a = b; b = temp;
        }
        static void SwapReference(ref double a, ref double b)
        {
            double temp = a;
            a = b; b = temp;
        }
        static void SwapValue(string a, string b)
        {
            string temp = a;
            a = b; b = temp;
        }
        static void SwapReference( ref string a, ref string b)
        {
            string temp = a;
            a = b; b = temp;
        }

        static void SwapValue(double[] a, double[] b)
        {
            double[] temp = a;
            a = b; b = temp;
        }
        static void SwapReference(ref double[] a, ref double[] b)
        {
            double[] temp = a;
            a = b; b = temp;
        }
        static void Main(string[] args)
        {
            // Trần Xuân Bách - 20206272
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Trần Xuân Bách - 20206272\n");
            double a = 3, b = 5;
            Console.WriteLine($"2 số a = {a}, b = {b}");
            SwapValue(a, b);
            Console.WriteLine($"Sau khi swap tham trị a = {a}, b = {b}");
            SwapReference(ref a, ref b);
            Console.WriteLine($"Sau khi swap tham chiếu a = {a}, b = {b}");

            string A = "SQL", B = "DATA";
            Console.WriteLine($"\n2 chuỗi A = {A}, B = {B}");
            SwapValue(A, B);
            Console.WriteLine($"Sau khi swap tham trị chuỗi 1 = {A}, chuỗi 2 = {B}");
            SwapReference(ref A, ref B);
            Console.WriteLine($"Sau khi swap tham trị chuỗi 1 = {A}, chuỗi 2 = {B}");

            double[] Ar1 = new double[] { 1, 2, 3 };
            double[] Ar2 = new double[] { 4, 5, 6 };
            Console.WriteLine($"\n2 mảng số là mảng1 = {Ar1[0]},{Ar1[1]},{Ar1[2]} , mảng 2 = {Ar2[0]},{Ar2[1]},{Ar2[2]}");
            SwapValue(Ar1, Ar2);
            Console.WriteLine($"Sau khi swap tham trị mảng1 = {Ar1[0]},{Ar1[1]},{Ar1[2]} , mảng 2 = {Ar2[0]},{Ar2[1]},{Ar2[2]}");
            SwapReference(ref Ar1, ref Ar2);
            Console.WriteLine($"Sau khi swap tham chiếu mảng1 = {Ar1[0]},{Ar1[1]},{Ar1[2]} , mảng 2 = {Ar2[0]},{Ar2[1]},{Ar2[2]}");

            Name bach = new Name("Bách", 20);
            Name mai = new Name("Mai", 17);
            Console.WriteLine($"\n2 obj A = {bach._Name},{bach._Age} B = {mai._Name},{mai._Age}");
            Name.SwapValue(bach, mai);
            Console.WriteLine($"Sau khi swap tham tri: A = {bach._Name},{bach._Age} B = {mai._Name},{mai._Age}");
            Name.SwapReference(ref bach,ref mai);
            Console.WriteLine($"Sau swap tham chiếu: A = {bach._Name},{bach._Age} B = {mai._Name},{mai._Age}");

            Console.WriteLine("Kết luận: kiểu số thực, chuỗi, mảng là kiểu tham trị\n\t chỉ có class và Object là kiểu tham chiếu");
        }
        
    }
}
