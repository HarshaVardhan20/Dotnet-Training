// Calculates factorial of a number using BigInteger.
using System;
using System.Numerics;

public class FactorialLarge
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        // Read number for factorial
        string? input = Console.ReadLine();

        if (!int.TryParse(input, out int n) || n < 0)
        {
            Console.WriteLine("Enter a valid non-negative integer");
            return;
        }

        BigInteger fact = 1;

        // Compute factorial
        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }

        Console.WriteLine($"{n}! = {fact}");
    }
}
