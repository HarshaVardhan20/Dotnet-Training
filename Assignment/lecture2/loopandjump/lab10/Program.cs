// A simple number guessing game.
public class lab13
{
    public static void Main()
    {
        Random random = new Random();
            int secretNumber = random.Next(1, 101);
            int userGuess = 0;

            Console.WriteLine("Enter a number between 1 and 100. Can you guess it?");

            // Loop until correct guess
            do
            {
                Console.Write("Enter your guess: ");
                // Read guess
                string? input = Console.ReadLine();

                if (int.TryParse(input, out userGuess))
                {
                    if (userGuess < secretNumber)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else if (userGuess > secretNumber)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                    else
                    {
                        Console.WriteLine("Congratulations! You've guessed the correct number!");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer.");
                }

            } while (userGuess != secretNumber);
        }
    }
