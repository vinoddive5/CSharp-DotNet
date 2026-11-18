using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_space
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a String");
            string str = Console.ReadLine();

            char[] arr = str.ToCharArray();

            int count = 0;
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] ==' ')
                {
                    count++;
                }
            }

            Console.WriteLine($"Number of spaces in a string is {count}");
            Console.ReadLine();
        }
    }
}
