using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Student
{
    internal class Student
    {
        public string Name { get; set; }
        public int[] Grade { get; set; }
        public double AverageGrade { get; set; }
        public void Student1()
        {
            int sum = 0;
            foreach (var gr in Grade)
            {
                sum += gr;
                AverageGrade = sum / Grade.Length;
            }

            Console.WriteLine($"Средният успех на {Name}: {AverageGrade:f2}.");
        }

        public void Student2()
        {
            int sum = 0;
            foreach (var gr in Grade)
            {
                sum += gr;
                AverageGrade = sum / Grade.Length;
            }

            Console.WriteLine($"Средният успех на {Name}: {AverageGrade:f2}.");
        }
    }
}
