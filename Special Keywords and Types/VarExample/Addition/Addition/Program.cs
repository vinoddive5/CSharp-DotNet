using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter First Number:");
            var a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Second Number:");
            var b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Addition is {a + b}");

            Console.ReadLine();

        }
    }
}
