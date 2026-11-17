using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Length
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a string ");
            string str = Console.ReadLine();

            char[] arr = str.ToCharArray();

            int length = 0;

            for(int i=0; i<arr.Length; i++)
            {
                length++;
            }

            Console.WriteLine(length);
            Console.ReadLine();
        }
    }
}
