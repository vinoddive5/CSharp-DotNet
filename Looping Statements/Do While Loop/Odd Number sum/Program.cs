using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Number_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            int i = 1;
            do
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
                i++;

            } while (i <= num);

            Console.WriteLine($"Sum of odd number up to {num} = {sum}");
            Console.ReadLine();
        }
    }
}
