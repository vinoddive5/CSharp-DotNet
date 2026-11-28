using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_var_value_and_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var RollNo = 101;
            var Name = "Vinod";
            var Marks = 89.5;
            var Grade = 'D';
            var Attendance = true;

            Console.WriteLine("------------- Var Variables Values And Data Type ----------");
            Console.WriteLine($"Roll No :- {RollNo} --- Variable Type => {RollNo.GetType()}");
            Console.WriteLine($"Name :- {Name} --- Variable Type => {Name.GetType()}");
            Console.WriteLine($"Marks :- {Marks} --- Variable Type => {Marks.GetType()}");
            Console.WriteLine($"Grade :- {Grade} --- Variable Type => {Grade.GetType()}");
            Console.WriteLine($"Attendance :- {Attendance} --- Variable Type => {Attendance.GetType()}");

            Console.ReadLine();
        }
    }
}
