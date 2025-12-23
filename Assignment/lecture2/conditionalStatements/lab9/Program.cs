using System;
using System.Security.Cryptography.X509Certificates;

public class lab9
{
    public static void Main()
    {
        Console.WriteLine("Enter x and y coordinates: ");
        // Read x and y coordinates
        String input1 = Console.ReadLine();
        String input2 = Console.ReadLine();
        if(int.TryParse(input1,out int x) && int.TryParse(input2,out int y))
        {
            // Determine quadrant or axis
            if(x<0 && y > 0)
            {
                Console.WriteLine("Quadrant 1");
            }
            else if(x>0 && y > 0)
            {
                Console.WriteLine("Quadrant 2");
            }
            else if(x<0 && y < 0)
            {
                Console.WriteLine("Quadrant 3");
            }
            else if(x>0 && y < 0)
            {
                Console.WriteLine("Quadrant 4");
            }
            else if(x==0 && y == 0)
            {
                Console.WriteLine("Origin");
            }
            else if(x==0)
            {
                Console.WriteLine("On Y Axix");
            }
            else
            {
                Console.WriteLine("On X axis");
            }
        }
        else
        {
            Console.WriteLine("Enter valid coordinates");
        }
    }
}