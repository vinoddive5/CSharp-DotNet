using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_if_else3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Character ");
            char ch = char.Parse(Console.ReadLine());

            if(char.IsLetter(ch))
            {
                if(ch=='a' | ch=='e' | ch=='i' | ch=='o' | ch=='u' | ch=='A' | ch=='E' | ch=='I' | ch=='O' | ch=='U')
                {
                    Console.WriteLine("Vowel");
                }
                else
                {
                    Console.WriteLine("Consonant");
                }
            }
            else
            {
                Console.WriteLine("Not an alphabet");
            }

            Console.ReadLine();
        }
    }
}
