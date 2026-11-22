using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contains_Only_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a string:");
            string str = Console.ReadLine();

            bool isDigit = true;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] < '0' || str[i] > '9')
                {
                    isDigit = false;
                    break;
                }
            }

            if (isDigit && str.Length > 0)
            {
                Console.WriteLine("String contains only digits.");
            }
            else
            {
                Console.WriteLine("String does not contain only digits.");
            }

            Console.ReadLine();
        }
    }
}
