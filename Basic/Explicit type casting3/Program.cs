using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_type_casting3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Product info");
            decimal prodprice = decimal.Parse(Console.ReadLine());
            int p;
            p = Convert.ToInt32(prodprice);

            Console.WriteLine("Product Price before conversion " + prodprice);
            Console.WriteLine("Price after conversion " + p);

            Console.ReadLine();
        }
    }
}
