using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_number_of_digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a digit");
            int num = int.Parse(Console.ReadLine());

            int count = 0;
            while (num>0)
            {
                count++;
                num = num / 10;
            }
            Console.WriteLine($"Total digits are {count}");
            Console.ReadLine();
        }
    }
}
