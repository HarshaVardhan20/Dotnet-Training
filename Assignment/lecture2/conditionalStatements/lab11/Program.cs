using System;
using System.Runtime.CompilerServices;

public class lab11
{
    public static bool isLeapYear(int year)
    {
        return (year%400==0) || (year%4==0 && year % 100 != 0);
    }
    public static void Main()
    {
        Console.WriteLine("Enter date, month and year");
        // Read day, month, year inputs
        String? day = Console.ReadLine();
        String? month = Console.ReadLine();
        String? year = Console.ReadLine();
        if(int.TryParse(year, out int y) && int.TryParse(month, out int m) && int.TryParse(day, out int d) && y>0)
        {
            bool isDateValid = false;
            // Validate date based on month
            if(m=="January" || m=="March" || m=="May" || m=="July" || m=="August" || m=="October" || m == "December")
            {
                if (d <= 31)
                {
                    isDateValid = true;
                }
            }
            else if(m=="April" || m=="June" || m=="September" || m == "November")
            {
                if (d <= 30)
                {
                    isDateValid = true;
                }
            }
            else
            {
                if((isLeapYear(y) && d <= 29) || d<=28)
                {
                    isDateValid = true;                    
                }
            }
            // Output validity
            if (isDateValid)
            {
                Console.WriteLine("Date is valid");
            }
            else
            {
                Console.WriteLine("Date is invalid");
            }
        }
    }
}