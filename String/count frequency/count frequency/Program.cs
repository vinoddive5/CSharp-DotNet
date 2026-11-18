using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count_frequency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a String");
            string str = Console.ReadLine();

            char[] arr = str.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;

                if (arr[i] == '0')
                    continue;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        arr[j] = '0';
                    }
                }

                Console.WriteLine(arr[i] + " = " + count);
            }

            Console.ReadLine();
        }
    }
}
}
