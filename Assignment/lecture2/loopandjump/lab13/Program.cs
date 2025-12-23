// Simulates ATM withdrawal with balance check.
using System;

public class labATM
{
    public static void Main()
    {
        Console.WriteLine("Insert card? (yes/no)");
        // Read card insertion
        string? card = Console.ReadLine();

        if (card == "yes")
        {
            Console.Write("Enter PIN: ");
            // Read PIN
            string? pinInput = Console.ReadLine();

            if (int.TryParse(pinInput, out int pin) && pin == 1234)
            {
                Console.Write("Enter balance: ");
                // Read balance
                string? balInput = Console.ReadLine();

                if (int.TryParse(balInput, out int balance))
                {
                    Console.Write("Enter withdrawal amount: ");
                    // Read amount
                    string? amtInput = Console.ReadLine();

                    if (int.TryParse(amtInput, out int amount))
                    {
                        // Check withdrawal
                        if (balance >= amount)
                        {
                            Console.WriteLine("Withdrawal successful");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient balance");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid balance");
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
