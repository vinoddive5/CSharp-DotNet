using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_the_factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number ");
            int num = int.Parse(Console.ReadLine());

            int fact = 1;
            for(int i=1; i<=num; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine($"Factorial = {fact}");
            Console.ReadLine();
        }
    }
}
