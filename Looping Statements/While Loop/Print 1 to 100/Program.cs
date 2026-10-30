using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_1_to_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while(i<=100)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.ReadLine();
        }
    }
}
