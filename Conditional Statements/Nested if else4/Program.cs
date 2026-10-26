using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_if_else4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your salary:");
            int salary = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter years of experience:");
            int exp = int.Parse(Console.ReadLine());

            if (salary > 30000)
            {
                if (exp >= 5)
                {
                    Console.WriteLine("Employee is eligible for bonus.");
                }
                else
                {
                    Console.WriteLine("Employee is not eligible due to experience.");
                }
            }
            else
            {
                Console.WriteLine("Employee is not eligible due to salary.");
            }

            Console.ReadLine();
        }
    }
}
