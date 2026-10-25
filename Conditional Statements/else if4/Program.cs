using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace else_if4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age ");
            int age = int.Parse(Console.ReadLine());

            if(age < 0)
            {

                Console.WriteLine("Invalid Age ");
            }
            else if(age <= 12)
            {
                Console.WriteLine("Child");
            }
            else if(age <= 19)
            {
                Console.WriteLine("Teenager");
            }
            else if(age < 60)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Senior Citizen");  
            }

            Console.ReadLine();
        }
    }
}
