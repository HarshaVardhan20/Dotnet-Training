using System;

public class labPalindrome
{
    public static void Main()
    {
        Console.Write("Enter number: ");
        // Read number to check
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int num))
        {
            int original = num;
            int rev = 0;

            // Reverse the number
            while (num > 0)
            {
                int digit = num % 10;
                rev = rev * 10 + digit;
                num = num / 10;
            }

            Console.WriteLine($"Reversed number: {rev}");

            // Check if palindrome
            if (original == rev)
            {
                Console.WriteLine("Palindrome number");
            }
            else
            {
                Console.WriteLine("Not a palindrome number");
            }
        }
        else
        {
            Console.WriteLine("Enter valid integer");
        }
    }
}
