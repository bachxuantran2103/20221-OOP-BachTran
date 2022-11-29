using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace Demo_Builder_Pattern_for_any_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Trần Xuân Bách - 20206272
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            KhoiTao1 createdemo = new KhoiTao1();
            createdemo.TaoPhanNho("Ho", "Trần Xuân");
            createdemo.TaoPhanNho("Ten", "Bách");
            createdemo.TaoPhanNho("Tuoi", "20");
            Demo demo1 = createdemo.Ketqua();
            Console.WriteLine(demo1.ToString());

            KhoiTaoAll Tcreate = new KhoiTaoAll();
            Tcreate.TaoPhanNho("Ho", "Trần Xuân");
            Tcreate.TaoPhanNho("Ten", "Bách");
            Tcreate.TaoPhanNho("Tuoi", "22");
            Demo demo2 = Tcreate.Ketqua();
            Console.WriteLine(demo2.ToString());
            
            Demo test3 = new Demo().BuildPart("Ten", "Bách").BuildPart("Ho", "Trần Xuân").BuildPart("Tuoi", "25");
            Console.WriteLine(test3.ToString());

            /*

            Director director = new Director();

            Builder b1 = new ConcreteBuilder1();
            Builder b2 = new ConcreteBuilder2();

            // Construct two products

            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();

            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();

            // Wait for user

            Console.ReadKey();
            */

        }
        
    }
}
