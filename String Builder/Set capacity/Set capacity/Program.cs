using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_capacity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            sb.Capacity = 50;

            sb.Append("Vinod Dive");

            Console.WriteLine("String: " + sb);
            Console.WriteLine("Capacity: " + sb.Capacity);

            Console.ReadLine();
        }
    }
}
