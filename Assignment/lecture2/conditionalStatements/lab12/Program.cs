using System;

public class Lab16
{
    public static void Main()
    {
        Console.WriteLine("Insert card (yes/no): ");
        // Read card insertion choice
        string? cardInput = Console.ReadLine();

        if (cardInput == "yes")
        {
            Console.WriteLine("Enter PIN: ");
            // Read PIN input
            string? pinInput = Console.ReadLine();

            if (int.TryParse(pinInput, out int pin) && pin == 1234)
            {
                Console.WriteLine("Enter withdrawal amount: ");
                // Read withdrawal amount
                string? amountInput = Console.ReadLine();

                if (int.TryParse(amountInput, out int amount))
                {
                    int balance = 5000;

                    // Check if withdrawal is possible
                    if (amount <= balance)
                    {
                        Console.WriteLine("Please collect your cash");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient balance");
                    }
                }
                else
                {
                    Console.WriteLine("Enter valid amount");
                }
            }
            else
            {
                Console.WriteLine("Invalid PIN");
            }
        }
        else
        {
            Console.WriteLine("Card not inserted");
        }
    }
}
