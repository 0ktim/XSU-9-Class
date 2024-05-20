
using System.Xml.Linq;

namespace _01.Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Random rd = new Random();
            Console.Write("Въведете име: ");
            student1.Name = Console.ReadLine();

            if (student1.Name == "Venelin")
            {
                student1.Grade = new int[10];

                for (int i = 0; i < student1.Grade.Length; i++)
                {
                    student1.Grade[i] = rd.Next(2, 7);
                }

                Console.WriteLine($"Оценки: {string.Join(", ", student1.Grade)}.");
                student1.Student1();
                
            }

            else if (student1.Name == "Emma Aleksieva")
            {
                //Random rd2 = new Random();
                //Console.Write("Въведете име: ");
                //student1.Name = Console.ReadLine();
                student1.Grade = new int[10];

                for (int i = 0; i < student1.Grade.Length; i++)
                {
                    student1.Grade[i] = rd.Next(2, 7);
                }

                Console.WriteLine($"Оценки: {string.Join(", ", student1.Grade)}.");
                student1.Student2();
            }
        }
    }
}
