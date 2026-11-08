using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Number ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nOdd Numbers upto {num}");
            for(int i=1; i<=num; i++)
            {
                if(i%2!=0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
