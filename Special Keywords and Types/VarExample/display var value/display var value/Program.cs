using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace display_var_value
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var a = 100;
            Console.WriteLine($"Variable Value is {a}");
            Console.WriteLine($"Variable Taype is {a.GetType()}");

            Console.ReadLine();
        }
    }
}
