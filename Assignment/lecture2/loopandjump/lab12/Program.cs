// Prints numbers from 1 to 50, skipping multiples of 3.
using System;

public class lab12
{
    public static void Main()
    {
        // Loop and skip multiples of 3
        for(int i = 1; i <= 50; i++)
        {
            if (i % 3 == 0)
            {
                continue;
            }
            Console.Write($"{i} ");
        }
    }
}