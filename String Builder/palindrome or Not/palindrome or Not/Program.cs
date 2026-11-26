using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome_or_Not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a String ");
            string str = Console.ReadLine();

            StringBuilder sb = new StringBuilder(str);

            StringBuilder rev = new StringBuilder();

            for(int i=sb.Length-1; i>=0; i--)
            {
                rev.Append(sb[i]);
            }

            if(sb.ToString().Equals(rev.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("String is Palindrome");

            }
            else
            {
                Console.WriteLine("String is Not Palindrome");
            }

            Console.ReadLine();
        }
    }
}
