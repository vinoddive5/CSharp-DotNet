using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_even_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            int i = 1;
            do
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;

            } while (i <= num);

            Console.ReadLine();
        }
    }
}
