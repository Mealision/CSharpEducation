using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask24
{
    enum Gender
    {
        male,
        female
    }

    internal class Person
    {
        string FirstName;
        string LastName;
        int Age;
        Gender Gender;

        public void Greet()
        {
            Console.WriteLine($"Greetings {LastName} {FirstName}");
        }

        private static int counter = 0;
        public static int Count => counter;

        public Person(string firstName, string lastName, int age, Gender Gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = Gender;
            counter++;
        }

    }
}
