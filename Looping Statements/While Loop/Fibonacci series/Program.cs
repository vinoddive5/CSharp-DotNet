using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;

            int i = 1;
            while(i<=num)
            {
                Console.Write(a + " ");
                int c = a + b;
                a = b;
                b = c;

                i++;
            }

            Console.ReadLine();
        }
    }
}
