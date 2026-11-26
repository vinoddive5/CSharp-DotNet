using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Space
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a String ");
            string str = Console.ReadLine();

            StringBuilder sb = new StringBuilder(str);

            foreach(var i in sb.ToString())
            {
                if(i != ' ')
                {
                    Console.Write(i);
                }
            }
            Console.ReadLine();
        }
    }
}
