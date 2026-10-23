using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_If2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            int n = Convert.ToInt32(Console.ReadLine());

            if(n < 0)
            {
                Console.WriteLine("Number is negative ");
            }

            Console.ReadLine();

        }
    }
}
