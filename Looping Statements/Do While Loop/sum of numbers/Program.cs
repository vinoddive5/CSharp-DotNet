using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nSum of numbers upto {num}");
            int sum = 0;
            int i = 0;
            do
            {
                sum += i;
                i++;

            } while (i <= num);

            Console.WriteLine($"Sum is {sum}");
            Console.ReadLine();
        }
    }
}
