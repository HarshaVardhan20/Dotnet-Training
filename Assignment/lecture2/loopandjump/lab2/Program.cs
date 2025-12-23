using System;
using System.Runtime.CompilerServices;

public class lab2
{
    public static void Main()
    {
        Console.WriteLine("Enter the number to check it is prime");
        // Read number to check
        String? input = Console.ReadLine();
        if(int.TryParse(input, out int num) && num >= 0)
        {
            if (num <= 1)
            {
                Console.WriteLine($"{num} is not prime");
                return;
            }
            if (num <= 3)
            {
                Console.WriteLine($"{num} is prime");
                return;
            }
            if(num%2==0 || num % 3 == 0)
            {
                Console.WriteLine($"{num} is not prime");
                return;
            }
            // Check for factors up to sqrt(num)
            for(int i = 5; i * i <= num; i += 6)
            {
                if(num%i==0 || (num % (i + 2)) == 0)
                {
                    Console.WriteLine($"{num} is not prime");
                    return;
                }
            }
            Console.WriteLine($"{num} is prime");
        }
        else
        {
            Console.WriteLine("Enter valid number to check prime");
        }
    }
}