using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_number_1_to_10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = 10;
            for(int i=1; i<=num; i++)
            {
                Console.Write(i+" ");
            }

            Console.ReadLine();
        }
    }
}
