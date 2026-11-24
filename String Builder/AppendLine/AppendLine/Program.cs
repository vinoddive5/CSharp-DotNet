using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(".Net Programming");
            sb.AppendLine("2026");
            Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}
