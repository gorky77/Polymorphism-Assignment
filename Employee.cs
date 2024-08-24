using System;

namespace ConsoleAppProject
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        // This method implements the Quit method from the IQuittable interface.
        public void Quit()
        {
            Console.WriteLine("The employee has quit.");
        }

        // Inherits the SayName() method from the Person class.
    }
}
