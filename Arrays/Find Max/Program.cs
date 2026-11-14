using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Max
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Size of Array ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int max = 0;
            for(int i=0; i<arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }

            Console.WriteLine($"{max} is largest element in Array");
            Console.ReadLine();

        }
    }
}
