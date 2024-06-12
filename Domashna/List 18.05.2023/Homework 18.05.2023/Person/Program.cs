using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<Person> people = new List<Person>();
            people.Add(new Person("Ivan", 35, "Male"));
            people.Add(new Person("Gosho", 25, "Male"));
            people.Add(new Person("Maria", 18, "Female"));
            people.Add(new Person("Jivka", 25, "Female"));
            
            



           
        }
    }
}