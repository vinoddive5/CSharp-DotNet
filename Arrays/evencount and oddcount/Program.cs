using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evencount_and_oddcount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Elements in Array ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            int EvenCount = 0;
            int OddCount = 0;

            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for(int i=0; i<arr.Length;  i++)
            {
                if (arr[i]%2==0)
                {
                    EvenCount++;
                }
                else
                {
                    OddCount++;
                }
            }

            Console.WriteLine($"{EvenCount} Even Elements and \n{OddCount} Odd Elements in Array");
            Console.ReadLine();
        }
    }
}
