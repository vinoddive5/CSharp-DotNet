using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace else_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter operator (+, -, *, /)");
            char op = Convert.ToChar(Console.ReadLine());

            if(op == '+')
            {
                Console.WriteLine($"Addition is {a + b}");
            }
            else if(op == '-')
            {
                Console.WriteLine($"Subtraction is {a - b}");
            }
            else if(op == '*')
            {
                Console.WriteLine($"Multiplication is {a * b}");
            }
            else if(op == '/')
            {
                if(b != 0)
                {
                    Console.WriteLine($"Division is {a / b}");
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
            }
            else
            {
                Console.WriteLine("Invalid operator.");
            }

            Console.ReadLine();
        }
    }
}
