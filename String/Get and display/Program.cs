using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_and_display
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PLease Enter a String ");
            string str = Console.ReadLine();

            char[] arr = str.ToCharArray();

            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadLine();
        }
    }
}
