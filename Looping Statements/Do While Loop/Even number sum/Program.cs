using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_number_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number ");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;

            int i = 1;
            do
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
                i++;
            } while (i <= num);

            Console.WriteLine($"Sum of even numbers upto {num} = {sum}");
            Console.ReadLine();
        }
    }
}
