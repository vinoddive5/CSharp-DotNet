using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delete_Character
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

            sb.Remove(pos, 1);

            Console.WriteLine("After Removing: " + sb);

            Console.ReadLine();
        }
    }
}
