using System;

class Program
{
    static void Main()
    {
        const double CmPerFoot = 30.48;

        Console.Write("Enter feet: ");
        // Read feet input from user
        string? input = Console.ReadLine();

        if (!double.TryParse(input, out double feet))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            return;
        }

        if (feet < 0)
        {
            Console.WriteLine("Feet cannot be negative.");
            return;
        }

        // Convert feet to centimeters
        double cm = feet * CmPerFoot;
        // Display the result
        Console.WriteLine($"{feet} feet = {cm:F2} cm");
    }
}
