using System;

public class lab3
{
    public static void Main()
    {
        Console.Write("Enter year: ");
        // Read year input
        string? input = Console.ReadLine();
        if(int.TryParse(input,out int year))
        {
            // Check if leap year
            if(year%400==0 || (year%4==0 && year % 100 != 0))
            {
                Console.WriteLine($"{year} is a leap year");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year");
            }
        }
        else
        {
            Console.WriteLine("Enter a valid year.");
        }
    }
}