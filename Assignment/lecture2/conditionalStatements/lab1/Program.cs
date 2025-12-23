using System;

public class lab1
{
    public static void Main()
    {
        // Read height input from user
        string? input = Console.ReadLine();
        string category = string.Empty;
        if(int.TryParse(input,out int height))
        {
            // Determine category based on height
            if(height < 150)
            {
                category = "Dwraf";
            }
            else if (height < 165)
            {
                category = "Average";
            }
            else if (height <=190)
            {
                category = "Tall";
            }
            else
            {
                category = "Abnormal";
            }
        }
        // Display the category
        Console.WriteLine($"Person belongs to category {category}");
    }
}