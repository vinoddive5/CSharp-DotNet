using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implicit_type_casting3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Product Info");
            int prodquantity = int.Parse(Console.ReadLine());
            float prodprice = float.Parse(Console.ReadLine());

            double totalBill = prodquantity * prodprice;

            Console.WriteLine("Product Quantity " + prodquantity);
            Console.WriteLine("Product Price " + prodprice);
            Console.WriteLine("Total Bill " + totalBill);

            Console.ReadLine();
        }
    }
}
