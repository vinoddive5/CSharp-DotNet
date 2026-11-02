using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_10_to_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            int num = int.Parse(Console.ReadLine());

            int i = 10;
            do
            {
                Console.WriteLine(i);
                i--;
            }
            while (i>=1);

            Console.ReadLine();
        }
    }
}
