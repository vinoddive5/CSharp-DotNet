using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a string ");
            string str = Console.ReadLine();

            string strupper = str.ToUpper();

            Console.WriteLine($"Convert String in upper case == {strupper}");
            Console.ReadLine();
        }
    }
}
