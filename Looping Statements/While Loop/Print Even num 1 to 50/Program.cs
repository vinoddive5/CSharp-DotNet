using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Even_num_1_to_50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number ");
            int num = int.Parse(Console.ReadLine());


            Console.WriteLine("Even numbers");
            int i = 1;
            while(i <= num)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i); 
                }
                i++;
            }
            Console.ReadLine();
        }
    }
}
