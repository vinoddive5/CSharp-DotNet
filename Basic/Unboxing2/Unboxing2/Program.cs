using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unboxing2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string str1 = "100";
            string str2 = "123.4";
            string str3 = "A";
          

            int a = int.Parse(str1);
            float b = float.Parse(str2);
            char c = Char.Parse(str3);


            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.ReadLine();



        }
    }
}
