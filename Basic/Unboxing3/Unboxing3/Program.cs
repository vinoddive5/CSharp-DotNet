using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unboxing3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "5";

            int a = int.Parse(str);

            int square = a * a;

            Console.WriteLine("Number: " + a);
            Console.WriteLine("Square: " + square);
            Console.ReadLine();
        }
    }
}
