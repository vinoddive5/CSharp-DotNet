using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a String ");
            string str = Console.ReadLine();

            string rev = null;

            for(int i=str.Length-1; i>=0; i--)
            {
                rev += str[i];
            }

            if(rev==str)
            {
                Console.WriteLine("String is Palindrome");
            }
            else
            {
                Console.WriteLine("String is not Palindrome");
            }

            Console.ReadLine();
                
        }
    }
}
