using System;

public class lab8
{
    public static void Main()
    {
        Console.WriteLine("Enter lengths of three sides of triangle: ");
        // Read three side lengths
        String? input1 = Console.ReadLine();
        String? input2 = Console.ReadLine();
        String? input3 = Console.ReadLine();
        if(int.TryParse(input1, out int len1) && int.TryParse(input2, out int len2) && int.TryParse(input3, out int len3))
        {
            // Determine triangle type
            if(len1 == len2 && len2 == len3)
            {
                Console.WriteLine("Triangle is Equilateral");
            }
            if(len1==len2 || len2==len3 || len1 == len3)
            {
                Console.WriteLine("Triangle is Isosceles");
            }
            else
            {
                Console.WriteLine("Triangle is Scalene");
            }
        }
        else
        {
            Console.WriteLine("Enter valid triangle input lengths.");
        }
    }
}