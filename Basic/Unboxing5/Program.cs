using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unboxing5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int res;
            string str = null;
           // res = int.Parse(str);
            res = Convert.ToInt32(str);

            Console.WriteLine("Converting string is a numeric representation " + res);
            Console.ReadLine();
        }
    }
}
