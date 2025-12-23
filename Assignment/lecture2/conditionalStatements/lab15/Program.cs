using System;

public class Lab15
{
    public static void Main()
    {
        Console.WriteLine("Enter number1, number2 and operation (+, -, *, /):");

        // Read two numbers and operation
        string? number1 = Console.ReadLine();
        string? number2 = Console.ReadLine();
        string? operation = Console.ReadLine();

        if (int.TryParse(number1, out int num1) &&
            int.TryParse(number2, out int num2) &&
            char.TryParse(operation, out char op) &&
            (op == '+' || op == '-' || op == '*' || op == '/'))
        {
            // Perform the operation
            switch (op)
            {
                case '+':
                    Console.WriteLine($"Output is {num1 + num2}");
                    break;

                case '-':
                    Console.WriteLine($"Output is {num1 - num2}");
                    break;

                case '*':
                    Console.WriteLine($"Output is {num1 * num2}");
                    break;

                case '/':
                    Console.WriteLine($"Output is {num1 / num2}");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Enter valid operands and operator");
        }
    }
}
