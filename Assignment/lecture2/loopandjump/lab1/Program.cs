using System;

public class lab1
{
    public static void Main()
    {
        Console.Write("Enter the number to see that numebr of fibonacci series: ");
        // Read number of terms
        string? input = Console.ReadLine();
        if(int.TryParse(input,out int n) && n >= 1)
        {
            int first = 0;
            int second = 1;
            Console.WriteLine("Below the Fibinacci sequence:");
            if (n <= 1)
            {
                Console.WriteLine(0);
                return;   
            }
            
            // Generate and print Fibonacci series
            for(int i = 0; i <n; i++)
            {
                Console.Write($"{first} ");
                int curr = first + second;
                first = second;
                second = curr;
            }
        }
        else
        {
            Console.WriteLine("Enter valid number to see Fibonacci series");   
        }
    }
}