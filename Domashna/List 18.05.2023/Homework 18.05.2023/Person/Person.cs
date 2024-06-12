using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
       
        
       

        

       

    public Person (string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;

            void filter(int age,string gender ) {
                foreach (var people in gender)
                {
                    if (gender == "Male")
                    {
                        if (age == 25)
                        {
                            Console.WriteLine(Name);
                        }
                    }
                }



            }

        }




        
    }
}

