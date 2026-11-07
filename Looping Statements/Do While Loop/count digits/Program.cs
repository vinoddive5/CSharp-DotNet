using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count_digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number ");
            int num = int.Parse(Console.ReadLine());

            int count = 0;
            do
            {
                num = num / 10;
                count++;

            } while (num > 0);

            Console.WriteLine($"Count of Digits is {count}");
            Console.ReadLine();
        }
    }
}
