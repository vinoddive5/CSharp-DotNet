using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Hii");
            sb.AppendLine("Hello");

            sb.Replace("Hello", "Good Night");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
