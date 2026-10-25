using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace else_if3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number (1 - 7)");
            int n = Convert.ToInt32(Console.ReadLine());

            if(n==1)
            {
                Console.WriteLine("Sunday");
            }
            else if(n==2)
            {
                Console.WriteLine("Monday");
            }
            else if(n==3)
            {
                Console.WriteLine("Tuesday");
            }
            else if(n==4)
            {
                Console.WriteLine("Wednesday");
            }
            else if(n==5)
            {
                Console.WriteLine("Thursday");
            }
            else if(n==6)
            {
                Console.WriteLine("Friday");
            }
            else if(n==7)
            {
                Console.WriteLine("Saturday");
            }
            else
            {
                Console.WriteLine("Invalid day number ");
            }

            Console.ReadLine();
        }
    }
}
