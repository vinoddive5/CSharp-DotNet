using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_if_else2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age ");
            int age = int.Parse(Console.ReadLine());

            if(age >= 18)
            {
                Console.WriteLine("Are you registered to vote? (yes/no)");
                string reg = Console.ReadLine();

                if(reg == "yes")
                {
                    Console.WriteLine("You are eligible to vote.");
                }
                else
                {
                    Console.WriteLine("Please Register for vote.");
                }
            }
            else
            {
                Console.WriteLine("You are not eligible for vote.");
            }

            Console.ReadLine();
        }
    }
}
