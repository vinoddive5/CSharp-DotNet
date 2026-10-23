using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_if4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            int n = int.Parse(Console.ReadLine());

            if(n%5==0)
            {
                Console.WriteLine("number divisible by 5");
            }

            Console.ReadLine();
        }
    }
}
