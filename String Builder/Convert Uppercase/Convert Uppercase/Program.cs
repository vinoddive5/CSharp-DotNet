using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Uppercase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "hello";

            StringBuilder sb = new StringBuilder(str.ToUpper());

            Console.WriteLine("Original string " + str);
            Console.WriteLine("UpperCase String " + sb);

            Console.ReadLine();
        }
    }
}
