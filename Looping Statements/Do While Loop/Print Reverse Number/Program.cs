using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Reverse_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            int rev=0;
            int rem;

            do
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }
            while (num > 0);

            Console.WriteLine("Reverse number: "+ rev);
            Console.ReadLine();
        }
    }
}
