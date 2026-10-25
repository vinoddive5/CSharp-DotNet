using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace else_if5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter marks ");
            int m1 = int.Parse(Console.ReadLine());
            int m2 = int.Parse(Console.ReadLine());
            int m3 = int.Parse(Console.ReadLine());
            int m4 = int.Parse(Console.ReadLine());
            int m5 = int.Parse(Console.ReadLine());

            Console.WriteLine("-----------------------------------------------------------------------------------");
            int total = m1 + m2 + m3 + m4 + m5;
            Console.WriteLine($"Total Marks :-- {total}");

            Console.WriteLine("-----------------------------------------------------------------------------------");
            double percentage = total / 5.0;
            Console.WriteLine($"Pracentage is :-- {percentage}%");

            if(percentage >= 90)
            {
                Console.WriteLine("Grade :--  A+");
            }
            else if(percentage >= 75 && percentage <= 89)
            {
                Console.WriteLine("Grade :-- A");
            }
            else if(percentage >= 60 && percentage <= 74)
            {
                Console.WriteLine("Grade :-- B");
            }
            else if(percentage >= 45 && percentage <= 59)
            {
                Console.WriteLine("Grade :-- C");
            }
            else if(percentage >= 35 && percentage <= 44)
            {
                Console.WriteLine("Grade :-- D");
            }
            else
            {
                Console.WriteLine("Fail");
            }

            Console.ReadLine();
        }
    }
}
