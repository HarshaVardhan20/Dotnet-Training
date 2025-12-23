using System;

public class lab2
{
    public static void Main()
    {
        String? input1,input2,input3;
        Console.WriteLine("Enter three numebrs: ");
        // Read three numbers from user
        input1 = Console.ReadLine();
        input2 = Console.ReadLine();
        input3 = Console.ReadLine();
        if(int.TryParse(input1, out int num1) && int.TryParse(input2,out int num2) && int.TryParse(input3,out int num3))
        {
            // Find the largest number
            if (num1 >= num2)
            {
                if (num1 >= num3)
                {
                    Console.WriteLine($"{num1} is greater");
                }
                else
                {
                    Console.WriteLine($"{num3} is greater");
                }
            }
            else
            {
                if (num2 >= num3)
                {
                    Console.WriteLine($"{num2} is greater");
                }
                else
                {
                    Console.WriteLine($"{num3} is greater");
                }
                
            }
        }
    }
}