// Finds pairs from two arrays that sum to a target value.
using System;

public class lab15
{
    public static void Main()
    {
        Console.WriteLine("Enter number to search:");
        // Read target sum
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int target))
        {
            int[] arr1 = { 10, 20, 30, 40, 50 };
            int[] arr2 = { 5, 15, 25, 35, 45 };

            bool found = false;

            // Search for pairs
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] + arr2[j] == target)
                    {
                        Console.WriteLine($"Found using arr1[{i}] and arr2[{j}]");
                        found = true;
                        goto EXIT;
                    }
                }
            }

        EXIT:
            if (!found)
            {
                Console.WriteLine("Value not found");
            }
        }
        else
        {
            Console.WriteLine("Enter valid number");
        }
    }
}
