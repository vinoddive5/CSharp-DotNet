using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_type_casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d = 101.222;
            int i;
            i = Convert.ToInt32(d);
            Console.WriteLine("the value of d is :" + d);
            Console.WriteLine(" the value of i is :" + i);
            Console.ReadLine();
        }
    }
}
