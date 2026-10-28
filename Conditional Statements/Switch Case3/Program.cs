using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter traffic light color (Red, Yellow, Green):");
            string color = Console.ReadLine().ToLower();

            switch (color)
            {
                case "red":
                    Console.WriteLine("Stop!");
                    break;

                case "yellow":
                    Console.WriteLine("Get Ready!");
                    break;

                case "green":
                    Console.WriteLine("Go!");
                    break;

                default:
                    Console.WriteLine("Invalid traffic light color!");
                    break;
            }

            Console.ReadLine();
        }

    }
}
