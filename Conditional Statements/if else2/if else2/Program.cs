using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your age ");
            int age = int.Parse(Console.ReadLine());

            if(age>=18)
            {
                Console.WriteLine("you are eligible for vote");
            }
            else
            {
                Console.WriteLine("you are not eligible for vote");
            }

            Console.ReadLine();
        }
    }
}
