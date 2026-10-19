using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            object obj = b;
            Console.WriteLine(b);
            Console.WriteLine(obj);
            Console.ReadLine();
        }
    }
}
