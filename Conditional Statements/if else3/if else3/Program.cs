using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            int n = int.Parse(Console.ReadLine());

            if(n % 2 == 0)
            {
                Console.WriteLine($"{n} is even number ");
            }
            else
            {
                Console.WriteLine($"{n} is odd number ");
            }

            Console.ReadLine();
        }
    }
}
