using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Number ");
            int num = int.Parse(Console.ReadLine());

            
            int sum = 0;
            do
            {
                int rem = num % 10;
                sum += rem;
                num = num / 10;

            } while (num > 0);

            Console.WriteLine($"Sum of Digit {sum}");
            Console.ReadLine();
        }
    }
}
