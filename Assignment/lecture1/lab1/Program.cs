using System;
class lab1
{
    public static void Main()
    {
        Console.Write("Enter Radius: ");
        // Read radius input from user
        string? input = Console.ReadLine();
        if(double.TryParse(input, out double radius))
        {
            // Calculate the area of the circle
            double area = Math.PI * radius * radius;
            // Display the calculated area
            Console.WriteLine($"Radius of circle is {area:F2}");
        }
        else
        {
            Console.WriteLine("Enter valid radius type");
        }
    }
}