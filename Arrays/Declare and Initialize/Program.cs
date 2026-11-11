using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declare_and_Initialize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {10,20,30,40,50};

            Console.WriteLine("Array Elements:");
            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
