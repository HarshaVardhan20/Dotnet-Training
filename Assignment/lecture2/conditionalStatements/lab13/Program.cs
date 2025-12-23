using System;

public class Lab13
{
    public static void Main()
    {
        Console.WriteLine("Enter cost price and selling price:");
        // Read cost and selling prices
        string? costPrice = Console.ReadLine();
        string? sellingPrice = Console.ReadLine();

        if (int.TryParse(costPrice, out int cp) &&
            int.TryParse(sellingPrice, out int sp) &&
            cp > 0 && sp >= 0)
        {
            // Calculate profit or loss percentage
            if (cp == sp)
            {
                Console.WriteLine("No profit, no loss");
            }
            else if (cp > sp)
            {
                double lossPercent = ((cp - sp) * 100.0) / cp;
                Console.WriteLine($"Loss percentage: {lossPercent:F2}%");
            }
            else
            {
                double profitPercent = ((sp - cp) * 100.0) / cp;
                Console.WriteLine($"Profit percentage: {profitPercent:F2}%");
            }
        }
        else
        {
            Console.WriteLine("Enter valid cost price and selling price");
        }
    }
}
