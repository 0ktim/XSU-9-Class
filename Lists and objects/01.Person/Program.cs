using Microsoft.VisualBasic;

namespace _01.Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            people.Add(new Person { Name = "Nataliq", Age = 19, Gender = "Female" });
            people.Add(new Person { Name = "Andreas", Age = 24, Gender = "Male" });
            people.Add(new Person { Name = "Victoriq", Age = 32, Gender = "Female" });

            Filter(people, 19, "Female");
        }
        static void Filter(List<Person> people, int age, string gender)
        {
            foreach (var person in people)
            {
                if (person.Age == age && person.Gender == gender)
                {
                    Console.WriteLine($"Name: {person.Name}, gender: {person.Gender}, age: {person.Age}. ");
                }
            }
        }
    }
}
