using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert_Specific_position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a String ");
            string str = Console.ReadLine();

            StringBuilder sb = new StringBuilder(str);

            Console.WriteLine("Enter Position: ");
            int pos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Character:");
            char ch = Convert.ToChar(Console.ReadLine());

            sb.Insert(pos, ch);
            
            Console.WriteLine("After Inserting: " + sb);

            Console.ReadLine();

        }
    }
}
