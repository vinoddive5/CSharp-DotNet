using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_ASCII_Values
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i] + " = " + (int)str[i]);
            }

            Console.ReadLine();
        }
    }
}
