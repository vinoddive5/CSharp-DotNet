using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a String ");
            string str = Console.ReadLine();

            char[] arr = str.ToCharArray();

            for(int i=arr.Length-1; i>=0; i--)
            {
                Console.Write(arr[i]);
            }

            Console.ReadLine();
        }
    }
}
