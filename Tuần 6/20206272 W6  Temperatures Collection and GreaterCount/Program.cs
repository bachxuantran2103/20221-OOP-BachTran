using System;
using System.Text;

namespace _20206272_W6_1__Temperatures_Collection
{
    internal class Program
    {
        static double MinTemp = 25;
        static void Main(string[] args)
        {
            // Trần Xuân Bách - 20206272
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            try
            {
                Random objRandom = new Random();
                //Bài 2.1
                Temperature objTempB1 = new Temperature();
                for (int i = 0; i < 50; i++) objTempB1._Listtemperatures.Add(objRandom.Next(0, 45));
                Console.WriteLine($"In the 2.1 have {Temperature.GreaterCount2_1(objTempB1._Listtemperatures, MinTemp)} tempuratures equal or exceed 25 degrees");

                // Bài 2.2
                double[] temp2 = new double[50];
                for (int i = 0; i < 50; i++) temp2[i] = (objRandom.Next(0, 45));
                Console.WriteLine($"In the 2.2 have {Temperature.GreaterCount2_2(temp2, MinTemp)} tempuratures equal or exceed 25 degrees");
            }
            catch(Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }


    }
}
