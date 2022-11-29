// Trần Xuân Bách - 20206272
using System;
using System.Numerics;
using System.Text;
using Atom;

namespace Atomic_Information
{
    // Trần Xuân Bách - 20206272
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Trần Xuân Bách - 20206272\nAtomic Information\n===========================");
                Atomic[] tuanhoan = new Atomic[3];
                for (int i = 0; i < tuanhoan.Length; i++)
                {
                    tuanhoan[i] = new Atomic();
                    tuanhoan[i] = Atomic.Getdata();
                }
                Console.WriteLine("\tWeight\n--------------------------\n");
                foreach (Atomic elem in tuanhoan)
                {
                    elem.Display();
                }
            }
            catch(Exception E)
            {
                Console.WriteLine(E.Message);
            }

        }
    }
}
