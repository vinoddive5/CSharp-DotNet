using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_sum_of_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number ");
            int num = int.Parse(Console.ReadLine());


            int sum = 0;
            for(int i=1; i<=num; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Sum of Totale Number is {sum}");
            Console.ReadLine();
        }
    }
}
