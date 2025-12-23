// Checks if a number is a strong number (sum of factorial of digits equals number).
using System;
using System.Data.Common;

public class lab14
{
    public static int factorial(int num)
    {
        if(num==0 || num == 1)
        {
            return 1;
        }   
        return num*factorial(num-1);
    }
    public static void Main()
    {
        Console.Write("Enter the number: ");
        // Read number to check
        String? number = Console.ReadLine();

        if(int.TryParse(number, out int num) && num > 0)
        {
            int total = 0;
            int temp = num;
            // Sum factorials of digits
            while (temp > 0)
            {
                int digit = temp%10;
                total += factorial(digit);
                temp = temp/10;
            }
            // Check if strong
            if (total == num && temp==0)
            {
                Console.WriteLine("sum of the factorial of digits is equal to the number");
            }
            Console.WriteLine("sum of the factorial of digits is not equal to the number");
        }
        else
        {
            Console.WriteLine("Enter valid input");
        }
    }    
}