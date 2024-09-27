using System;

namespace MathOperationApp
{
    // Create a class named MathOperations
    public class MathOperations
    {
        // Create a void method named PerformOperation
        // This method takes two integers as parameters: number1 and number2
        public void PerformOperation(int number1, int number2)
        {
            // Perform a simple math operation (e.g., addition) on the first integer
            int result = number1 + 10;

            // Display the result of the math operation
            Console.WriteLine("Result of math operation: " + result);

            // Display the second integer to the screen
            Console.WriteLine("Second integer: " + number2);
        }
    }

    class Program
    {
        // The Main method, the entry point of the console application
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the PerformOperation method with two numbers (e.g., 5 and 20)
            mathOps.PerformOperation(5, 20);

            // Call the PerformOperation method again, specifying parameters by name
            mathOps.PerformOperation(number1: 15, number2: 30);

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
