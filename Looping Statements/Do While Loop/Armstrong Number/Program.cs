using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            int temp = num;

            do
            {

                int rem = num % 10;
                sum += rem * rem * rem;
                num = num / 10;

            } while (num > 0);

            if (temp==sum)
            {
                Console.WriteLine($"{temp} is Armstrong Number ");
            }
            else
            {
                Console.WriteLine($"{temp} is not Armstrong Number");
            }

            Console.ReadLine();
        }
    }
}
