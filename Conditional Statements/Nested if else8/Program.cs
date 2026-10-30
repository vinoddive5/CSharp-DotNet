using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_if_else8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Account Balance:");
            double balance = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Withdrawal Amount:");
            double amt = double.Parse(Console.ReadLine());

            if (balance > 0)
            {
                if (amt > 0)
                {
                    if (amt <= balance)
                    {
                        Console.WriteLine("Withdrawal Successful!");
                        Console.WriteLine("Remaining Balance: " + (balance - amt));
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Balance!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Withdrawal Amount!");
                }
            }
            else
            {
                Console.WriteLine("Account Balance is Zero or Negative!");
            }

            Console.ReadLine();
            }
        }
}
