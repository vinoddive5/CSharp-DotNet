using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter string ");
            string str = Console.ReadLine();

            StringBuilder sb = new StringBuilder(str);

            int Count = 0;

            foreach(char ch in sb.ToString())
            {
                if(ch=='a' || ch=='e' || ch=='i' || ch=='o' || ch=='u' || ch=='A' || ch=='E' || ch=='I' || ch=='O' || ch=='U')
                {
                    Count++;
                }
            }

            Console.Write($"Vowels Count is {Count}");

            Console.ReadLine();
        }
    }
}
