using System;

namespace Branching_Assignment___Package_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.Write("Please enter the package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            Console.Write("Please enter the package width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the package height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the package length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int dimensionsTotal = width + height + length;

            if (dimensionsTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            int quote = width * height * length * weight / 100;

            Console.WriteLine("Your shipping quote is: $" + quote);
        }
    }
}