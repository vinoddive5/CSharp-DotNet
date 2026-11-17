using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lowercase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a string");
            string str = Console.ReadLine();

            string strLower = str.ToLower();

            Console.WriteLine($"Convert string into Lower case == {strLower}");
            Console.ReadLine();
        }
    }
}
