using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Duplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a string ");
            string str = Console.ReadLine();

            char[] arr = str.ToArray();


            Console.WriteLine("String after removing duplicates:");
            for(int i=0; i<arr.Length; i++)
            {
                bool duplicate = false;

                for (int j=0; j<i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        duplicate = true;
                        break;
                    }
                }

                if (!duplicate)
                {
                    Console.Write(arr[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
