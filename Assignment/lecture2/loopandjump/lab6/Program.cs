// Prints Pascal's triangle up to given rows.
using System;
using System.Collections.Generic;

public class lab6
{
    public static void Main()
    {
        Console.Write("Enter number of rows: ");
        // Read number of rows
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int rows) && rows >= 1)
        {
            List<int> prev = new List<int>();

            // Generate and print triangle
            for (int i = 1; i <= rows; i++)
            {
                for (int s = 1; s <= rows - i; s++)
                    Console.Write(" ");

                List<int> curr = new List<int>();
                curr.Add(1);
                Console.Write("1 ");

                for (int j = 0; j < prev.Count-1; j++)
                {
                    int val = prev[j] + prev[j+1];
                    curr.Add(val);
                    Console.Write(val + " ");
                }

                if (i > 1)
                {
                    curr.Add(1);
                    Console.Write("1");
                }

                Console.WriteLine();
                prev = curr;
            }
        }
        else
        {
            Console.WriteLine("Enter valid number of rows");
        }
    }
}
