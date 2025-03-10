using System;

class Program
{
    static void Main(string[] args)
    {
        // Display welcome message
        Console.WriteLine("Welcome to Speedy Delivery Service. Follow the instructions below.");

        // Get package weight
        Console.WriteLine("Please input the package weight in kg:");
        float weight = float.Parse(Console.ReadLine());

        // Check if package is too heavy
        if (weight > 40)
        {
            Console.WriteLine("Unfortunately, this package is too heavy to be shipped. Have a nice day.");
            return;
        }

        // Get package dimensions
        Console.WriteLine("Please input the package width in cm:");
        float width = float.Parse(Console.ReadLine());

        Console.WriteLine("Please input the package height in cm:");
        float height = float.Parse(Console.ReadLine());

        Console.WriteLine("Please input the package length in cm:");
        float length = float.Parse(Console.ReadLine());

        // Check if package is oversized
        if (width + height + length > 60)
        {
            Console.WriteLine("Package size exceeds the limit and cannot be shipped.");
            return;
        }

        // Calculate shipping quote
        float shipping_quote = (width * height * length * weight) / 150;

        // Display the final quote
        Console.WriteLine($"Your estimated shipping cost is: ${shipping_quote:F2}");
        Console.WriteLine("Thank you for using Speedy Delivery Service!");
    }
}
