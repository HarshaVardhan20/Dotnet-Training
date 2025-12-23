using System;

public class lab7
{
    public static void Main()
    {
        Console.WriteLine("Enter a character to check is it vowel or not: ");
        // Read character input
        String? input = Console.ReadLine();
        if(char.TryParse(input, out char ch))
        {
            // Check if vowel using switch
            switch (ch)
            {
                case 'a':
                    Console.WriteLine($"{ch} is a vowel");
                    return;
                case 'e':
                    Console.WriteLine($"{ch} is a vowel");
                    return;
                case 'i':
                    Console.WriteLine($"{ch} is a vowel");
                    return;
                case 'o': 
                    Console.WriteLine($"{ch} is a vowel");
                    return;
                case 'u':
                    Console.WriteLine($"{ch} is a vowel");
                    return;
            }
            Console.WriteLine($"{ch} is not a vowel");
        }
        else
        {
            Console.WriteLine("Enter valid character");
        }
    }
}