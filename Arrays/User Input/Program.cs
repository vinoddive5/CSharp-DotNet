using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Size of Array");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("\nArray elements is");
            for(int i=0; i<arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }

            Console.ReadLine();

        }
    }
}
