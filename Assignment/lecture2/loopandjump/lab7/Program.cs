// Converts binary string to decimal integer.
using System;

public class lab7
{
    public static bool isBinary(string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != '0' && str[i] != '1')
                return false;
        }
        return true;
    }

    public static void Main()
    {
        Console.Write("Enter binary: ");
        // Read binary string
        string? str = Console.ReadLine();

        if (string.IsNullOrEmpty(str))
        {
            Console.WriteLine("Enter valid binary string");
            return;
        }

        if (isBinary(str))
        {
            long value = 0;
            int len = str.Length;

            // Convert to decimal
            for (int i = len - 1; i >= 0; i--)
            {
                if (str[i] == '1')
                {
                    value += (1L << (len - i - 1));
                }
            }

            Console.WriteLine($"The integer representation of {str} is {value}");
        }
        else
        {
            Console.WriteLine("Enter valid binary string");
        }
    }
}
