using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_n_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number ");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            int i = 1;
            while(i<=num)
            {
                sum += i;
                i++;
            }

            Console.WriteLine($"Sum of n numbers {sum}");
            Console.ReadLine();

        }
    }
}
