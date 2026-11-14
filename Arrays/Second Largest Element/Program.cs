    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Second_Largest_Element
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

                int max = arr[0];
                for(int i=0; i<arr.Length; i++)
                {
                    if(max < arr[i])
                    {
                        max = arr[i];
                    }
                }

                int secondmax = int.MinValue;
                for(int i=0; i<arr.Length; i++)
                {
                  if(secondmax < arr[i] && max != arr[i])
                    {
                        secondmax = arr[i];
                    }
                }

                Console.WriteLine($"Second Largest Value in Array is {secondmax}");
                Console.ReadLine();
            }
        }
    }
