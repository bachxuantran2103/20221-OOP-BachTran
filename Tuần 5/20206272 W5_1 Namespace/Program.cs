using System;
using System.Text;
using _Customer;
using _Orders;

namespace _20206272_W5_1_Namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Trần Xuân Bách - 20206272
                Console.OutputEncoding = Encoding.Unicode;
                Console.InputEncoding = Encoding.Unicode;
                Customers objCustomer = new Customers("Bách");
                Console.WriteLine($"Current customer name: {objCustomer.ToString()}\nUpdate:");
                objCustomer.UpdateCustomerName(Console.ReadLine());
                bool check = true;
                while (check)
                {
                    Console.WriteLine("1. Buy grocery.\n2. Buy bread.");
                    switch (Console.ReadLine().ToLower())
                    {
                        case "1":
                            Console.WriteLine(Grocery.BuyGrocery());
                            break;
                        case "2":
                            Console.WriteLine(Bread.BuyBread());
                            break;
                        case "exit":
                            check = false;
                            break;
                    }
                }
            }
            catch( Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }
    }
}
