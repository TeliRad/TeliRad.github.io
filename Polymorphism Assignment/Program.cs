using System;

// Create an interface called IQuittable
interface IQuittable
{
    void Quit();
}

// Create an Employee class that inherits the IQuittable interface
class Employee : IQuittable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Implement the Quit method defined in the IQuittable interface
    public void Quit()
    {
        Console.WriteLine($"{FirstName} {LastName} has quit the job.");
    }
}

class Program
{
    static void Main()
    {
        // Create an Employee object
        Employee emp = new Employee
        {
            FirstName = "John",
            LastName = "Doe"
        };

        // Use polymorphism to create an object of type IQuittable
        IQuittable quittableEmployee = emp;

        // Call the Quit() method on the IQuittable object
        quittableEmployee.Quit();
    }
}
