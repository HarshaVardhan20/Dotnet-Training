using System;

public class lab4
{
    public static void Main()
    {

        Console.WriteLine("Enter values of a, b, c:");
        // Read coefficients a, b, c
        String? first = Console.ReadLine();
        String? second = Console.ReadLine();
        String? third = Console.ReadLine();
        if (double.TryParse(first, out double a) && double.TryParse(second, out double b) && double.TryParse(third,out double c))
        { 
            // Calculate discriminant
            double d = b * b - 4 * a * c; 

            // Determine roots based on discriminant
            if (d > 0)
            {
                double r1 = (-b + Math.Sqrt(d)) / (2 * a);
                double r2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Roots are real and distinct:");
                Console.WriteLine($"Root1 = {r1:F2}, Root2 = {r2:F2}");
            }
            else if (d == 0)
            {
                double r = -b / (2 * a);
                Console.WriteLine("Roots are real and equal:");
                Console.WriteLine($"Root = {r:F2}");
            }
            else
            {
                double real = -b / (2 * a);
                double imag = Math.Sqrt(-d) / (2 * a);
                Console.WriteLine("Roots are complex:");
                Console.WriteLine($"Root1 = {real:F2} + {imag:F2}i");
                Console.WriteLine($"Root2 = {real:F2} - {imag:F2}i");
            }
        }
        else
        {
            Console.WriteLine("Enter valid numbers to find quadratic eqution");   
        }    
    }
}