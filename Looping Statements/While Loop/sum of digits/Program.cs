using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers");
            int num = int.Parse(Console.ReadLine());
            
            int rev = 0;
            int sum = 0;
            while(num>0)
            {
                int rem = num % 10;
                sum += rem;
                num = num / 10;

            }
            Console.WriteLine($"Sum of digits {sum}");

            Console.ReadLine();
        }
    }
}
