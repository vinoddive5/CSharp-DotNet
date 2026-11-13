using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_of_Array_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Array Elements");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int[] arr = new int[n];

            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for(int i=0; i<arr.Length; i++)
            {
                sum += arr[i];
            }

            double avg = (double)sum / arr.Length;
            Console.WriteLine("Average = " + avg);

            Console.ReadLine();
        }
    }
}
