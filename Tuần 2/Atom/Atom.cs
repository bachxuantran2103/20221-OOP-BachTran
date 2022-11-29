// Trần Xuân Bách - 20206272
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atom
{
    public class Atomic
    {
        int AtomicNo;
        string Symbol;
        string AtomicName;
        double AtomicWeight;

        public Atomic() { }
        public static bool Accept(object[] dataAr, out Atomic A)
        {
            A = new Atomic();
            if (int.TryParse(dataAr[0].ToString(), out A.AtomicNo) && double.TryParse(dataAr[3].ToString(), out A.AtomicWeight))
            {
                if (double.Parse(dataAr[4].ToString()) > 0 && int.Parse(dataAr[0].ToString()) > 0)
                {
                    A.Symbol = dataAr[1].ToString();
                    A.AtomicName = dataAr[2].ToString();
                    return true;
                }
                else
                {
                    Console.WriteLine("Enter data again.");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Enter data again.");
                return false;
            }
        }
        public void Display()
        {
            Console.WriteLine(this.AtomicNo + this.Symbol.PadLeft(4) + this.AtomicName.PadLeft(8) + "\t\t" + this.AtomicWeight.ToString());
        }
        public static Atomic Getdata()
        {
            Atomic A = new Atomic();
            object[] dataAr = new object[4];
            do
            {
                Console.Write("Enter atomic number : ");
                dataAr[0] = Console.ReadLine();
                Console.Write("Enter symbol : ");
                dataAr[1] = Console.ReadLine();
                Console.Write("Enter full name : ");
                dataAr[2] = Console.ReadLine();
                Console.Write("Enter atomic weight : ");
                dataAr[3] = Console.ReadLine();
            }
            while (!Accept(dataAr, out A));
            return A;
        }
    }
}
