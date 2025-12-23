using System;

public class Lab14
{
    public static void Main()
    {
        Console.WriteLine("Enter the selects of person1 and person2 (R, P, S)");
        // Read choices for both players
        string? input1 = Console.ReadLine();
        string? input2 = Console.ReadLine();

        if (char.TryParse(input1, out char person1) &&
            char.TryParse(input2, out char person2))
        {
            // Determine winner
            if (person1 == person2)
            {
                Console.WriteLine("Draw");
            }
            else if (person1 == 'R')
            {
                if (person2 == 'P')
                    Console.WriteLine("person2 wins");
                else
                    Console.WriteLine("person1 wins");
            }
            else if (person1 == 'P')
            {
                if (person2 == 'R')
                    Console.WriteLine("person1 wins");
                else
                    Console.WriteLine("person2 wins");
            }
            else if (person1 == 'S')
            {
                if (person2 == 'R')
                    Console.WriteLine("person2 wins");
                else
                    Console.WriteLine("person1 wins");
            }
            else
            {
                Console.WriteLine("Enter valid input");
            }
        }
        else
        {
            Console.WriteLine("Enter valid input");
        }
    }
}
