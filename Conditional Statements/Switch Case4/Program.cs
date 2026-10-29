using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Area of Circle");
            Console.WriteLine("2. Area of Square");
            Console.WriteLine("3. Area of Rectangle");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter radius: ");
                    double r = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Area of Circle = " + (3.14 * r * r));
                    break;

                case 2:
                    Console.Write("Enter side: ");
                    double s = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Area of Square = " + (s * s));
                    break;

                case 3:
                    Console.Write("Enter length: ");
                    double l = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter breadth: ");
                    double b = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Area of Rectangle = " + (l * b));
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
                }

            Console.ReadLine();
             }
        }
}
