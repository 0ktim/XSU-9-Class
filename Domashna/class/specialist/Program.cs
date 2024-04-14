using System.ComponentModel.Design;

namespace specialist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            specialist specialist = new specialist();
            Console.Write("Въведете име на служител:");
            specialist.name = Console.ReadLine();
            Console.Write("Въведете отдел:");
            specialist.otdel = Console.ReadLine();
            Console.Write("Въведете заплата:");
            specialist.Salary = int.Parse(Console.ReadLine());

            Console.WriteLine("Искате ли да промените заплата или отдел?");
            string change = Console.ReadLine();
            if (change == "да")
            {
                Console.WriteLine("Отдел или заплата?");
                string or = Console.ReadLine();
                if (or == "отдел")
                {
                    specialist.changeotdel();
                }
                else  
                {
                    specialist.changesalary();
                }

            }
            else { specialist.allinformation(); }
           

        }
        
        }
    }
