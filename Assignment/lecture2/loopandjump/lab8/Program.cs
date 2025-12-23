// Prints a diamond pattern of stars.
using System;

public class lab8
{
    public static void Main()
    {
        Console.WriteLine("Enter the n to print diamond pattern: ");
        // Read size n
        String? input = Console.ReadLine();
        if(int.TryParse(input, out int num) && num>=0)
        {
            // Print upper half
            for(int i = 0; i < num; i++)
            {
                for(int j = 0; j < num - i - 1; j++)
                {
                    Console.Write("  ");
                }
                for(int j = 0; j < 2*i+1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            // Print lower half
            for(int i = num - 1; i >= 1; i--)
            {
                for(int j = 0; j < (num - i); j++)
                {
                    Console.Write("  ");
                }
                for(int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Enter valid input");
        }
    }
}