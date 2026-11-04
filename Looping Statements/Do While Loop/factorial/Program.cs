using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            int fact = 1;
            int i = 1;
            do
            {
                fact *= i;
                i++;
            } while (i <= num);

            Console.WriteLine($"factorial of {num} = {fact}");
            Console.ReadLine();
        }
    }
}
