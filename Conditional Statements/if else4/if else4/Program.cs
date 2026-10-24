using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character ");
            char ch = char.Parse(Console.ReadLine());

            if(ch=='a' | ch == 'e' | ch == 'i' | ch == 'o' | ch == 'u' | ch == 'A' | ch == 'E' | ch == 'I' | ch == 'O' | ch == 'U' )
            {
                Console.WriteLine("character is a vowel.");
            }
            else
            {
                Console.WriteLine("character is a consonant.");
            }

            Console.ReadLine();
        }
    }
}
