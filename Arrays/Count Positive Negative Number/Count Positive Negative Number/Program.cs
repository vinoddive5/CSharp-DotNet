using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Positive_Negative_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Size of Array ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            int PositiveCount = 0;
            int NegativeCount = 0;

            for (int i=0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i]>0)
                {
                    PositiveCount++;
                }
                else
                {
                    NegativeCount++;
                }
            }

            Console.WriteLine($"Positive Number Count in Array is {PositiveCount}\nNegative Number Count in Array is {NegativeCount}");
            Console.ReadLine();
        }
    }
}
