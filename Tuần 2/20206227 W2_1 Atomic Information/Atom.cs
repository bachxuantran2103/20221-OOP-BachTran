// Trần Xuân Bách - 20206272
using System;
using System.Collections;
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
        public static bool Accept(string[] dataAr, out Atomic A)
        {
            A = new Atomic();
            if (int.TryParse(dataAr[0].ToString(), out A.AtomicNo) && double.TryParse(dataAr[3].ToString(), out A.AtomicWeight))
            {
                if (double.Parse(dataAr[3].ToString()) > 0 && int.Parse(dataAr[0].ToString()) > 0)
                {
                    A.Symbol = dataAr[1].ToString();
                    A.AtomicName = dataAr[2].ToString();
                    return true;
                }
                else
                {
                    Console.WriteLine("Enter data again.\n");
                    return false;

                }
            }
            else
            {
                Console.WriteLine("Enter data again.\n");
                return false;
            }
        }
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
        public void Display()
        {
            /*Type valtype = this.GetType();
            if (valtype.BaseType.ToString() == "Systyem.Array")
            {
                Console.WriteLine("Weight".PadLeft(15) + "\n_________________________________________\n");
                foreach (Atomic element in this)
                {
                    Console.WriteLine(element.AtomicNo + element.Symbol.PadLeft(4) + element.AtomicName.PadLeft(8) + "\t\t" + element.AtomicWeight.ToString() + "\n");

                }
            }
            else
            {
                Console.WriteLine(this.AtomicNo + this.Symbol.PadLeft(4) + this.AtomicName.PadLeft(8) + "\t\t" + this.AtomicWeight.ToString());
            }*/
            Console.WriteLine(this.AtomicNo + this.Symbol.PadLeft(4) + this.AtomicName.PadLeft(8) + "\t\t" + this.AtomicWeight.ToString());
        }
        public static Atomic Getdata()
        {
            Atomic A = new Atomic();
            string[] dataAr = new string[4];
            do
            {
                Console.Write("\nEnter atomic number : ");
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
