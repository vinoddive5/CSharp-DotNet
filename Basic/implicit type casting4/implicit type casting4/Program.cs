using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implicit_type_casting4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Character:");
            char ch = Char.Parse(Console.ReadLine());

            int num = ch;
            long l = num;

            Console.WriteLine("Character  " + ch);
            Console.WriteLine("Integer Value " + num);
            Console.WriteLine("Long Value " + l);

            Console.ReadLine();
        }
    }
}
