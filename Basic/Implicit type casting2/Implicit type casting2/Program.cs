using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_type_casting2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studrollno = 11;
            int studage = 21;
            int marks = 65;

            long l = studrollno;
            float f = studage;
            double d = marks;

            Console.WriteLine("Student Roll No "+ l);
            Console.WriteLine("Student Age "+f);
            Console.WriteLine("Student Marks "+d);

            Console.ReadLine();
        }
    }
}
