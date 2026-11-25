using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_Capacity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a string ");
            string str = Console.ReadLine();

            StringBuilder sb = new StringBuilder(str);

            Console.WriteLine("String: " + sb);
            Console.WriteLine("Capacity: " + sb.Capacity);

            Console.ReadLine();
        }
    }
}
