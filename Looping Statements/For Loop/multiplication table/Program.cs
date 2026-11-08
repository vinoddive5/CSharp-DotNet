using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Number ");
            int num = int.Parse(Console.ReadLine());


            Console.WriteLine($"\nmultiplication table of {num}");
            for(int i=1; i<10; i++)
            {
                Console.WriteLine($" {num} * {i} = {num*i}");
            }

            Console.ReadLine();
        }
    }
}
