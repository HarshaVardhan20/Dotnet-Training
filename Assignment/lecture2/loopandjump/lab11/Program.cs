// Computes the digital root of a number.
public class lab11
{
    public static void Main()
    {
        
        Console.Write("Enter a number: ");
        // Read number for digital root
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int number) && number >= 0)
        {
            // Reduce to single digit
            while (number >= 10)
            {
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                number = sum;
            }
            Console.WriteLine($"The digital root is: {number}");
        }
        else
        {
            Console.WriteLine("Please enter a valid non-negative integer.");
        }
    }
}