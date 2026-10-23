using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number :- ");
            int a = int.Parse(Console.ReadLine());

            if(a>=0)
            {
                Console.WriteLine("Positive Number ");
            }
           
            Console.ReadLine();
        }
    }
}
