using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_If_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number ");
            int n = int.Parse(Console.ReadLine());

            if(n > 0)
            {
                Console.WriteLine($"{n } is Positive Number ");

                if(n %2==0)
                {
                    Console.WriteLine($"{n} is Even Number ");
                }
                else
                {
                    Console.WriteLine($"{n} is Odd Number");
                }
            }
            else if(n < 0)
            {
                Console.WriteLine($"{n} is Negative Number ");
            }
            else
            {
                Console.WriteLine("Number is Zero");
            }

            Console.ReadLine();
        }
    }
}
