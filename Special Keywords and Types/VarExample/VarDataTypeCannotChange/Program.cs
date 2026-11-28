using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarDataTypeCannotChange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 100;

            Console.WriteLine("Value: " + a);
            Console.WriteLine("Data Type: " + a.GetType());

            a = 200;
            Console.WriteLine("Updated Value: " + a);
            Console.ReadLine();
        }
    }
}
