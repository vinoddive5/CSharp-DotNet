using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Array Elements ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Normal Array Before Reverse");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }

            for (int i=0; i<arr.Length/2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = temp;
            }

            Console.WriteLine("\nReverse Array Elements");
            for(int i=0; i<arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }

            Console.ReadLine();
        }
    }
}
