using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace else_if2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a value ");
            int n = int.Parse(Console.ReadLine());

            if(n >= -9 && n <= 9)
            {
                Console.WriteLine("One digit number ");
            }
            else if(n >= -99 && n <= 99)
            {

                Console.WriteLine("Two digit number ");
            }
            else if(n >= -999 && n <= 999)
            {
                Console.WriteLine("Three digit number ");
            }
            else
            {
                Console.WriteLine("Number Greter then three digit ");
            }

            Console.ReadLine();
        }
    }
}
