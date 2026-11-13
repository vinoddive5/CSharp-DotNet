using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Size of Array ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            int sum = 0;
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nSum of All Array Elements ");
            for(int i=0; i<arr.Length; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine($"Sum = {sum}");
            Console.ReadLine();
        }
    }
}
