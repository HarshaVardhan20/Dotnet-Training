// Computes GCD and LCM of two numbers.
using System;

public class lab5
{
    public static void Main()
    {
        Console.Write("Enter two numbers: ");
        // Read two numbers
        string? input1 = Console.ReadLine();
        string? input2 = Console.ReadLine();

        if (!int.TryParse(input1, out int num1) || !int.TryParse(input2, out int num2))
        {
            Console.WriteLine("Invalid input");
            return;
        }

        int a = Math.Abs(num1);
        int b = Math.Abs(num2);

        if (a == 0 || b == 0)
        {
            Console.WriteLine($"GCD of {num1} and {num2} is {Math.Max(a, b)}");
            return;
        }

        int gcd = 1;

        // Calculate GCD
        for (int i = 2; i * i <= Math.Min(a, b); i++)
        {
            if (a % i == 0 && b % i == 0)
            {
                int countA = 0, countB = 0;

                while (a % i == 0)
                {
                    a /= i;
                    countA++;
                }

                while (b % i == 0)
                {
                    b /= i;
                    countB++;
                }

                int commonPower = Math.Min(countA, countB);
                gcd *= (int)Math.Pow(i, commonPower);
            }
        }

        // Remaining prime factor
        if (a == b)
        {
            gcd *= a;
        }

        Console.WriteLine($"GCD of {num1} and {num2} is {gcd}");

        // Calculate LCM
        int lcm = num1*num2/gcd;

        Console.WriteLine($"LCM of {num1} and {num2} is {lcm}");
    }
}
