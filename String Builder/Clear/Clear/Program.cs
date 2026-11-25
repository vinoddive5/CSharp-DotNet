using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nashik");
            sb.AppendLine("Pune");
            sb.AppendLine("Mumbai");
            sb.AppendLine("Nagpur");
            sb.AppendLine("Bhusawal");

            Console.WriteLine("Before Clear Method");
            Console.WriteLine(sb);

            sb.Clear();
            Console.WriteLine("After Clear Method");
            Console.WriteLine(sb);


           

        }
    }
}
