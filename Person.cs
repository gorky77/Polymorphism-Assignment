using System;

namespace ConsoleAppProject
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // This method writes the person's full name to the console.
        public void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}

