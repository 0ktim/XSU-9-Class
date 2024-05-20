using System.Net.Cache;

namespace _02.People
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<People> person = new List<People>();
            
            for (int i = 0; i < 10; i++)
            {
                People personal = new People();
                //personal.Age = 20 + i;
                Random age = new Random();
                personal.Age = age.Next(20, 71);
                personal.Name = $"Person{i + 1}";
                person.Add(personal);
                personal.Gender = i % 2 == 0 ? "Male" : "Female";   //if (i % 2 == 0) personal.Gender = "Male";
                                                                    //else personal.Gender = "Female";
            }
            int sum = 0;
            foreach (People persona in person)
            {
                sum += persona.Age / person.Count;
                Console.WriteLine($"{persona.Name}, Age: {persona.Age}, Gender: {persona.Gender}.");
            }
            Console.WriteLine($"Average year: {sum}");
        }
    }
}
