using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Person
{
    internal class Person
    {

        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public static void FilterPeople()
        {
            Person person = new Person();
            List<Person> femalePeople = new List<Person>();
            List<Person> malePeople = new List<Person>();
            femalePeople.Add(new Person { Name = "Olivia", Age = 19, Gender = "Female" });
            malePeople.Add(new Person { Name = "Andreas", Age = 24, Gender = "Male" });
            femalePeople.Add(new Person { Name = "Hataliq", Age = 19, Gender = "Female" });
            malePeople.Add(new Person { Name = "Preslav", Age = 28, Gender = "Male" });
            femalePeople.Add(new Person { Name = "Nikita", Age = 24, Gender = "Female" });
            malePeople.Add(new Person { Name = "Rodrigo", Age = 28, Gender = "Male" });
            femalePeople.Add(new Person { Name = "Adriana", Age = 19, Gender = "Female" });
            femalePeople.Add(new Person { Name = "Bonny", Age = 24, Gender = "Female" });
            femalePeople.Add(new Person { Name = "Linda", Age = 28, Gender = "Female" });
            malePeople.Add(new Person { Name = "Pitter", Age = 19, Gender = "Male" });

                Console.WriteLine("Female:");
                Console.WriteLine();
                foreach (var femalePerson in femalePeople)
                {
                    if (person.Gender == "Female")
                    {
                        switch (person.Age)
                        {
                            case 19:
                                Console.WriteLine("--19 години--");
                                Console.WriteLine($"{person.Name}.");
                                break;
                            case 24:
                                Console.WriteLine("--24 години--");
                                Console.WriteLine($"{person.Name}.");
                                break;
                            case 28:
                                Console.WriteLine("--28 години--");
                                Console.WriteLine($"{person.Name}.");
                                break;
                        }
                    }
                }
                Console.WriteLine(" ");
                Console.WriteLine("Искате ли информация за годините на мъжете?");
                string answer = Console.ReadLine();
                Console.Clear();
                if (answer == "Yes" || answer == "yes")
                {
                Console.WriteLine("Male");
                Console.WriteLine(" ");
                foreach (var malePerson in malePeople)
                    {
                        if (person.Gender == "Male")
                        {
                            switch (person.Age)
                            {
                                case 19:
                                    Console.WriteLine("--19 години--");
                                    Console.WriteLine($"{person.Name}");
                                    break;
                                case 24:
                                    Console.WriteLine("--24 години--");
                                    Console.WriteLine($"{person.Name}");
                                    break;
                                case 28:
                                    Console.WriteLine("--28 години--");
                                    Console.WriteLine($"{person.Name}");
                                    break;
                            }
                        }
                    }
                }
                else if (answer == "No" || answer == "no")
                {
                    Console.WriteLine("You don't want any information. Have a nice day!");
                }
            }
        }
    }

