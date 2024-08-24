using ConsoleAppProject;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate and initialize an Employee object
        Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };

        // Call the SayName() method
        employee.SayName();

        // Use polymorphism to call the Quit method
        IQuittable quittable = employee;
        quittable.Quit();

        Console.ReadLine();
    }
}
