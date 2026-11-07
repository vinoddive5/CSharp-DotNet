using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_prime_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number");
            int num = int.Parse(Console.ReadLine());

            int i = 1;
            int count = 0;

            do
            {
                if (num % i == 0)
                {
                    count++;
                }
                i++;

            } while (i <= num);

            if(count==2)
            {

                Console.WriteLine($"{num} is Prime number");
            }
            else
            {
                Console.WriteLine($"{num} is Not prime Number");
            }

            Console.ReadLine();
        }
    }
}
