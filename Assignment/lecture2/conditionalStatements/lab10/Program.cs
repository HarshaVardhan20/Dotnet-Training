using System;

public class lab10
{
    public static void Main()
    {
        Console.WriteLine("Enter the grade: ");
        // Read grade input
        string? input = Console.ReadLine();

        if (char.TryParse(input, out char grade))
        {
            grade = char.ToUpper(grade);

            // Describe the grade using switch
            switch (grade)
            {
                case 'E':
                    Console.WriteLine("Grade is Excellent");
                    break;
                case 'V':
                    Console.WriteLine("Grade is Very Good");
                    break;
                case 'G':
                    Console.WriteLine("Grade is Good");
                    break;
                case 'A':
                    Console.WriteLine("Grade is Average");
                    break;
                case 'F':
                    Console.WriteLine("Grade is Fail");
                    break;
                default:
                    Console.WriteLine("Enter a valid grade");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Enter a valid grade");
        }
    }
}
