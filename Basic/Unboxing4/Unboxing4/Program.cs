using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unboxing4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            object obj = a;
            int b = (int)obj;

            Console.WriteLine("Original Value " + a);
            Console.WriteLine("Boxed Value " + obj);
            Console.WriteLine("Unboxed Value " + b);

            Console.ReadLine();
        }
    }
}
