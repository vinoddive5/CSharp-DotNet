using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Vinod";

            int l = str.Length;

            object obj = l;

            Console.WriteLine("String: " + str);
            Console.WriteLine("Length: " + l);

            Console.ReadLine();
        }
    }
}
