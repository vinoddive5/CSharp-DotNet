using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------Square Calculator ------------------");
            Console.WriteLine("1. Calculate Area");
            Console.WriteLine("2. Calculate Perimeter");

            Console.WriteLine("Enter Your choice");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter side of square ");
            double side = Convert.ToDouble(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.WriteLine($"Area of square = {side * side}");
                    break;

                case 2:
                    Console.WriteLine($"Perimeter of square = {4 * side}");
                    break;

                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
