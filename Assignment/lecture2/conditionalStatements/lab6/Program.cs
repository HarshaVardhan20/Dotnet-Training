using System;
using System.Reflection.Metadata;

public class lab6
{
    public static void Main()
    {
        Console.Write("Enter units: ");
        // Read electricity units consumed
        String? input = Console.ReadLine();
        if(int.TryParse(input, out int units) && units>=0)
        {
            double total = 0;
            // Calculate bill based on slab rates
            if (units <= 199)
            {
                total= units * 1.20;
            } 
            else if (units <= 400)
            {
                total = 199*1.20 + (units-199)*1.50;
            }
            else if (units <= 600)
            {
                total = 199*1.20 + 201*1.80 + (units-400)*1.80;
            }
            else
            {
                total = 199*1.20 + 201*1.80 + 200*1.80 + (units-600)*2.0;
            }
            if (total > 400)
            {
                total += (total * 0.15);
            }
            // Display total bill
            Console.WriteLine($"Total bill is {total:F2}");
        }
        else
        {
            Console.WriteLine("Enter valid numeber of units");
        }
    }  
}