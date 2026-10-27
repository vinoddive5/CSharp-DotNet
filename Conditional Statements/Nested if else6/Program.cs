using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_if_else6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year :");
            int year = int.Parse(Console.ReadLine());

            if(year % 4 == 0)
            {
                if(year % 100 == 0)
                {
                    if(year % 400 == 0)
                    {
                        Console.WriteLine("Leap Year ");
                    }
                    else
                    {
                        Console.WriteLine("Not a leap year");
                    }
                }
                else
                {
                    Console.WriteLine("Leap year");
                }   
            }
            else
            {
                Console.WriteLine("Not a leap year ");
            }

            Console.ReadLine();
        }

    }
}
