using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            string str = "20";

            a = int.Parse(str);

            Console.WriteLine("the value of str is  " +str);
            Console.WriteLine("the value of a is " + a);

            Console.ReadLine();
            
        }
    }
}
