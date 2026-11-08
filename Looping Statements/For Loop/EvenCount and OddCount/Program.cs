using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenCount_and_OddCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Number");
            int num = int.Parse(Console.ReadLine());

            int EvenCount = 0;
            int OddCount = 0;
            for(int i=1; i<=num; i++)
            {
                if(i%2==0)
                {
                    EvenCount++;
                }
                else
                {
                    OddCount++;
                }

            }

            Console.WriteLine($"Total Even Number is {EvenCount} and Total Odd Number is {OddCount}");
            Console.ReadLine();
        }
    }
}
