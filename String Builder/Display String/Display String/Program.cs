using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string ");
            string str = Console.ReadLine();

            StringBuilder sb = new StringBuilder(str);

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
