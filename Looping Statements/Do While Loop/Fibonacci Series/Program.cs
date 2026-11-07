using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number ");
            int num = int.Parse(Console.ReadLine());

            int a = 0, b = 1, c;
            int i = 1;

            do
            {
                Console.Write(a + " ");

                c = a + b;
                a = b;
                b = c;
                i++;

            } while (i <= num);

            Console.ReadLine();
        }
    }
}
