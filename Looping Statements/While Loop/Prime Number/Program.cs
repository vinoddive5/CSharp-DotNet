using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter number");
            int num = int.Parse(Console.ReadLine());

            int i = 1;
            int count = 0;

            while (i <= num)
            {
                if (num % i == 0)
                {
                    count++;

                }
                i++;

            }

            if(count==2)
            {
                Console.WriteLine("Prime Number ");
            }
            else
            {
                Console.WriteLine("Not Prime Number");
            }

            Console.ReadLine();
        }
    }
}
