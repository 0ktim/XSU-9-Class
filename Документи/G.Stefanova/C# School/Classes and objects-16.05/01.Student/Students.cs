using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Student
{
    internal class Students
    {
        public Students(string name, int[] grades)
        {
            this.Name = name;
            this.Grades = grades;
        }

        public string Name { get; set; }
        public int[] Grades { get; set; }
        
        public void AverageGrades()
        {
            int sum = 0;
            for (int i = 0; i < Grades.Length; i++)
            {
                sum += Grades[i];
            }
            double averageGrades = sum / Grades.Length;
            Console.WriteLine($"{averageGrades:f2}");
        }
    }
}
