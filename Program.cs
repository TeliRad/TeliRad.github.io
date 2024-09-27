
using System;

// Create a class
public class MathOperations
{
    // Create a void method that takes two integers as parameters
    public void PerformOperation(int num1, int num2)
    {
        // Do a math operation on the first integer
        int result = num1 * 2;

        // Display the second integer to the screen
        Console.WriteLine($"Result: {result}, Second Number: {num2}");
    }
}

class Program
{
    static void Main()
    {
        // Instantiate the class
        MathOperations math = new MathOperations();

        // Call the method in the class, passing in two numbers
        math.PerformOperation(5, 10);

        // Call the method in the class, specifying the parameters by name
        math.PerformOperation(num1: 3, num2: 6);
    }
}