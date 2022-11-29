using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Customer
{
    internal class Customers
    {
        private string _CustomerName;
        public Customers(string customerName)
        {
            _CustomerName = customerName;
        }

        public string UpdateCustomerName(string newname)
        {
            _CustomerName = newname;
            return this._CustomerName;
        }
        public override string ToString()
        {
            return _CustomerName;
        }
    }
}
namespace _Orders
{
    internal class Grocery
    {
        public static string BuyGrocery()
        {
            return "Groceries have been paid";
        }
    }
    internal class Bread
    {
        public static string BuyBread()
        {
            return "Groceries have been paid";
        }
    }
}
