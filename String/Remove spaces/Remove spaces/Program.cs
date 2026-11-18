using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_spaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a String ");
            string str = Console.ReadLine();

            char[] arr = str.ToCharArray();
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] != ' ')
                {
                    Console.Write(arr[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
