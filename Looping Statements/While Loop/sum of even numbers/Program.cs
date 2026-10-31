using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_even_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            int i = 1;
            while(i<=num)
            {
                if(i%2==0)
                {
                    sum += i;
                }
                i++;
            }

            Console.WriteLine($"Sum of all even numbers is {sum}");
            Console.ReadLine();
        }
    }
}
