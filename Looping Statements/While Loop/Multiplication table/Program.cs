using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            int num = int.Parse(Console.ReadLine());



            Console.WriteLine();
            Console.WriteLine("Multiplication table of "+ num);
            int i = 1;
            while(i<=10)
            {
                Console.WriteLine(num * i);
                i++;
            }
            Console.ReadLine();
        }
    }
}
