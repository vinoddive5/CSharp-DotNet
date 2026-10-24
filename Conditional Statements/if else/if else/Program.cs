using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            int n = int.Parse(Console.ReadLine());

            if(n>=0)
            {
                Console.WriteLine("positive number. ");
            }
            else
            {
                Console.WriteLine("negative number. ");
            }
            
            Console.ReadLine();
        }
    }
}
