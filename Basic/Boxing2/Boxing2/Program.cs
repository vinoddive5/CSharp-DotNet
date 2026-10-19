using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            double b = 145.55;
            char c = 'A';

            object x = a;
            object y = b;
            object z = c;

            Console.WriteLine(x+"  "+y+"  "+z);
            Console.ReadLine();

        }
    }
}
