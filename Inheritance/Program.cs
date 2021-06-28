using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Person[] persons = new Person[3] {

            new Student{FirstName="Fatma"},
            new Customer{FirstName="Usame" },
            new Person{FirstName="Merve" }


            };


            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);

            }


        }
    }
}
