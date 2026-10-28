using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------- Calculator -------------------");

            Console.WriteLine("Enter First number ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second number ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nChoose any Operator (+,-,*,/)");
            char op = char.Parse(Console.ReadLine());

            if(op=='+')
            {
                Console.WriteLine($"Addition is {num1 + num2}");
            }
            else if(op=='-')
            {
                Console.WriteLine($"Subtraction is {num1 - num2}");
            }
            else if(op=='*')
            {
                Console.WriteLine($"Multiplication is {num1 * num2}");
            }
            else if(op == '/')
            {
                if(num2 != 0)
                {
                    Console.WriteLine($"Division is {num1 / num2}");
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero ");
                }
            }
            else
            {
                Console.WriteLine("Invalid operator!"); ;
            }
            Console.WriteLine("----------------------------------------------------");

            Console.ReadLine();
        }
    }
}
