using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_if_else7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter marks for subject 1:");
            int m1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter marks for subject 2:");
            int m2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter marks for subject 3:");
            int m3 = int.Parse(Console.ReadLine());

            double avg = (m1 + m2 + m3) / 3.0;

            if(m1 >= 35 && m2 >= 35 && m3 >= 35)
            {
                if(avg >= 75)
                {
                    Console.WriteLine("Pass with Distinction.");
                }
                else
                {
                    Console.WriteLine("Pass without Distinction");
                }
            }
            else
            {
                Console.WriteLine("Fail..");
            }

            Console.ReadLine();
        }
    }
}
