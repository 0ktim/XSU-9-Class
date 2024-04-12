using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace specialistt
{
    internal class specialist
    {
        public string Name;

        public double Salary;

        public string department;

        public void moreSalary()
        {
            if (Salary != 0)
            {
                if (department == "Компютърни науки")
                {
                    Salary = Salary + 230;
                    Console.WriteLine($"Вашата заплата е {Salary}лв.");
                }
                else if (department == "Биология" || department == "Химия")
                {
                    Salary += Salary + 120;
                    Console.WriteLine($"Вашата заплата е {Salary}лв.");
                }
                else
                {
                    Salary = Salary + 50;
                    Console.WriteLine($"Вашата заплата е {Salary}лв.");
                }
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
        public void changeDepartment()
        {
            Console.WriteLine("Искаш ли да се преместиш в друг отдел?");
            Thread.Sleep(2000);
            Console.Clear();

            if (department == "Компютърни науки")
            {
                department = "Биология или Химия";
                Console.WriteLine("Можеш да смениш отдел Компютърни науки с отдел Биология или Химия.");

            }
            else if (department == "Биология" || department == "Химия")
            {
                department = "Компютърни науки";
                Console.WriteLine("Можеш да смениш отгел Биология или Химия с отдел Компютърни науки");
            }
            else
            {
                Console.WriteLine($"Изберете с какви професии искате да смените настоящата Ви {department}");
                
                Console.WriteLine();

                Console.WriteLine("Имате право между Учител, Пилот, Философ и Рибар!");

            }
        }
    }
}
