using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Hiii");
            sb.AppendLine("Helllo");

            sb.Remove(2,2);
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
