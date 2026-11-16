using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duplicate_Value
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please Enter Size of Array ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Array Duplicate Elements ..");

            int isduplicate = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.Write(arr[i]+" ");
                        break;
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
