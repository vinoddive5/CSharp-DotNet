using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Duplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a String ");
            string str = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            foreach(char ch in str)
            {
                if(!sb.ToString().Contains(ch))
                {
                    sb.Append(ch);
                }
            }

            Console.WriteLine("String after removing duplicates: " + sb);
            Console.ReadLine();
        }
    }
}
