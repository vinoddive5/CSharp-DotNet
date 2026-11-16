
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascending_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Size of Array ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            int temp;
           
            for (int i=0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

           
            for(int i=0; i<arr.Length; i++)
            {

                for(int j=i+1; j<arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine("Array in Ascending Order:");
            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]+" ");
            }

            Console.ReadLine();
        }
    }
}
