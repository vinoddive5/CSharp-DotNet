using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert_text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Friends");
            sb.AppendLine("Good Morning");

            sb.Insert(0,"Helloo ");
            Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}
