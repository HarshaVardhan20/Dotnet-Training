using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter total seconds: ");
        // Read total seconds input
        string? input = Console.ReadLine();

        if (!int.TryParse(input, out int totalSeconds))
        {
            Console.WriteLine("Invalid input. Please enter a whole number.");
            return;
        }

        if (totalSeconds < 0)
        {
            Console.WriteLine("Seconds cannot be negative.");
            return;
        }

        // Calculate minutes and remaining seconds
        int minutes = totalSeconds / 60;
        int remainingSeconds = totalSeconds % 60;

        // Display the breakdown
        Console.WriteLine($"{totalSeconds} seconds = {minutes} minute(s) and {remainingSeconds} second(s)");
    }
}
