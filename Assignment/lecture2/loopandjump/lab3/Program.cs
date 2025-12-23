using System;

public class lab3
{
    public static void Main()
    {
        Console.WriteLine("Enter number to check if it is Armstrong: ");
        // Read number to check
        String? input = Console.ReadLine();
        if(int.TryParse(input, out int num) && num >0)
        {
            String str = num.ToString();
            int len = str.Length;
            long sum = 0;
            int temp = num;
            // Calculate sum of powers
            while (temp > 0)
            {
                int digit = temp%10;
                sum += (long)Math.Pow(digit, len);
                temp = temp/10;
            }
            // Check if Armstrong
            if ((int)sum == num)
            {
                Console.WriteLine($"{num} is a armstrong number");
            }
            else
            {
                Console.WriteLine($"{num} is not a armstrong number");
            }
        }
        else
        {
            Console.WriteLine("Enter valid input number");
        }
    }
}