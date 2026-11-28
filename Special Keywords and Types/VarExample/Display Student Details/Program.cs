using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_Student_Details
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Student Details :-- ");
            var Name = Console.ReadLine();
            var Age = int.Parse(Console.ReadLine());
            var Percentage = double.Parse(Console.ReadLine());

            Console.WriteLine("---------- Student Details ---------");
            Console.WriteLine($"Name - {Name}\nAge - {Age}\nPercentage - {Percentage}%");

            Console.ReadLine();
           
        }
    }
}
