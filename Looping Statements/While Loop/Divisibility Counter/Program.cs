using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisibility_Counter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            int num = int.Parse(Console.ReadLine());

            int count = 0;
            int i = 1;
            while(i<=num)
            {
                if(i % 5 == 0)
                {
                    count++;
                }
                i++;
            }

            Console.WriteLine($"{count} numbers are divisible by 5 between 1 and 50.");
            Console.ReadLine();
        }
    }
}
