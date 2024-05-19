using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public static void Filter()
        {
            List<Person> people = new List<Person>();
            List<Person> people1 = new List<Person>();
            people1.Add(new Person { Name = "Alice", Age = 20, Gender = "Female" });
            people1.Add(new Person { Name = "Abigail", Age = 20, Gender = "Female" });
            people1.Add(new Person { Name = "Alexa", Age = 22, Gender = "Female" });
            people1.Add(new Person { Name = "Amber", Age = 22, Gender = "Female" });
            people1.Add(new Person { Name = "Amy", Age = 25, Gender = "Female" });
            people1.Add(new Person { Name = "Charlotte", Age = 25, Gender = "Female" });
            people.Add(new Person { Name = "Alejandro", Age = 20, Gender = "Male" });
            people.Add(new Person { Name = "Eric", Age = 20, Gender = "Male" });
            people.Add(new Person { Name = "Gordon", Age = 22, Gender = "Male" });
            people.Add(new Person { Name = "Jacob", Age = 22, Gender = "Male" });
            people.Add(new Person { Name = "Peter", Age = 25, Gender = "Male" });
            people.Add(new Person { Name = "Sergio", Age = 25, Gender = "Male" });
            while (true)
            {


                Console.WriteLine("Мъже:");
                Console.WriteLine();
                foreach (var person in people)
                {
                    if (person.Gender == "Male")
                    {
                        switch (person.Age)
                        {
                            case 20:
                                Console.Write("На 20 години: ");
                                Console.WriteLine($"{person.Name}.");
                                break;
                            case 22:
                                Console.Write("На 22 години: ");
                                Console.WriteLine($"{person.Name}.");
                                break;
                            case 25:
                                Console.Write("На 25 години: ");
                                Console.WriteLine($"{person.Name}.");
                                break;
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Искате ли да видите информация за жените?");
                Console.WriteLine();
                string change = Console.ReadLine();
                if (change == "yes")
                {
                    Console.Clear();
                    Console.WriteLine("Жени:");
                    Console.WriteLine();
                    foreach (var person in people1)
                    {
                        if (person.Gender == "Female")
                        {
                            switch (person.Age)
                            {
                                case 20:
                                    Console.Write("На 20 години: ");
                                    Console.WriteLine($"{person.Name}.");
                                    break;
                                case 22:
                                    Console.Write("На 22 години: ");
                                    Console.WriteLine($"{person.Name}.");
                                    break;
                                case 25:
                                    Console.Write("На 25 години: ");
                                    Console.WriteLine($"{person.Name}.");
                                    break;
                            }
                        }
                    }
                }
                else if (change == "no")
                {
                    while (true)
                    {
                        break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid command");
                }
                Thread.Sleep(2500);
                Console.Clear();
            }
        }
    }
}
