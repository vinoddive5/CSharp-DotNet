using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers ");
            int num = int.Parse(Console.ReadLine());

            int max = 0;
            while(num>0)
            {
                int rem = num % 10;
                
                if(rem>max)
                {
                    max = rem;
                }

                num = num / 10;
            }

            Console.WriteLine($"Largest digit is {max}");

            Console.ReadLine();
        }
    }
}
