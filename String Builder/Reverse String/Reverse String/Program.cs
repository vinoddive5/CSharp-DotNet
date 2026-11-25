using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a string ");
            string str = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for(int i=str.Length-1; i>=0; i--)
            {
                sb.Append(str[i]);
            }

            Console.WriteLine("Original String:- " + str);
            Console.WriteLine("Reverse String:- " + sb);

            Console.ReadLine();
        }
    }
}
