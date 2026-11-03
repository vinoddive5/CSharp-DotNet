using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_multiplication_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());


            Console.WriteLine($"\nmultiplication table of {num}");
            int i = 1;
            do
            {
                Console.WriteLine($"{num} * {i} = {i * num}");
                i++;

            } while (i <= 10);

            Console.ReadLine();

        }
    }
}
