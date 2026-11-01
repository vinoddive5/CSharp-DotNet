using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            int num = int.Parse(Console.ReadLine());

            int rev = 0;
            int temp = num;
            while(num>0)
            {
                int rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;

            }

            if(temp==rev)
            {
                Console.WriteLine("Number is palindrome");
            }
            else
            {
                Console.WriteLine("Not palindrome");
            }

            Console.ReadLine();
        }
    }
}
