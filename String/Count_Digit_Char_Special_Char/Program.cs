using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Digit_Char_Special_Char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a String");
            string str = Console.ReadLine();


            int CharacterCount = 0;
            int NumberCount = 0;
            int SpecialCount = 0;

            Char[] arr = str.ToCharArray();
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i]>='A' && arr[i]<='Z' 
                    || arr[i] >= 'a' && arr[i]<='z')
                {
                    CharacterCount++;
                }
                else if (arr[i]>='0' && arr[i]<='9')
                {
                    NumberCount++;
                }
                else
                {
                    SpecialCount++;
                }
            }

            Console.WriteLine($"Total Alphabets: {CharacterCount} \nTotal Numbers: {NumberCount} \nSpecial Character Count {SpecialCount}");
            Console.ReadLine();

        }
    }
}
