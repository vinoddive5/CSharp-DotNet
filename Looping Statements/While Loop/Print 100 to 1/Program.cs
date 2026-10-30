using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_100_to_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            while(i>=1)
            {
                Console.WriteLine(i);
                i--;
            }
            Console.ReadLine();
        }
    }
}
