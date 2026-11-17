using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Vowel_and_consonants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a String ");
            string str = Console.ReadLine();

            char[] arr = str.ToCharArray();

            int CountVowel = 0;
            int CountConsonant = 0;

            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i]=='A' || arr[i] == 'E' || arr[i] == 'I' || arr[i] == 'O' || arr[i] == 'U' || arr[i] == 'a' || arr[i] == 'e' || arr[i] == 'i' || arr[i] == 'o' || arr[i] == 'u' )
                {
                    CountVowel++;
                }
                else
                {
                    CountConsonant++;
                }
            }

            Console.WriteLine($"Count of Vowels is {CountVowel} \nCount of Consonant {CountConsonant}");
            Console.ReadLine();
        }
    }
}
