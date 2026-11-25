using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Lowecase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "NasHiK";

            StringBuilder sb = new StringBuilder(str.ToLower());

            Console.WriteLine("Original string value is " + str);
            Console.WriteLine("Lowercase string " + sb);

            Console.ReadLine();
        }
    }
}
