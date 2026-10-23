using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_if3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value ");
            int n = int.Parse(Console.ReadLine());

            if(n==100)
            {
                Console.WriteLine("equal to 100 ");
            }

            Console.ReadLine();
        }
    }
}
