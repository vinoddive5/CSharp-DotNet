using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_if_else5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username");
            string username = Console.ReadLine();

            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();

            if(username=="admin")
            {
                if(password=="pass@123")
                {
                    Console.WriteLine("Login Successful.");
                }
                else
                {
                    Console.WriteLine("Incorrect password");
                }
            }
            else
            {
                Console.WriteLine("Incorrect Username");
            }

            Console.ReadLine();
        }
    }
}
