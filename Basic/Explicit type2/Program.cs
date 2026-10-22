using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_type2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long l = 45000;
            short s;
            s = (short)l;

            Console.WriteLine("Long Value: " + l);
            Console.WriteLine("Short Value: " + s);

            Console.ReadLine();
        }
    }
}
