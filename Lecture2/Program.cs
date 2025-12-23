using System;

public class Lecture2
{
    public static bool isEven(int number)
    {   if(number % 2 == 0)
        {
            return true;
        }
        return false;
        
    }
    public static void Main(string[] args)
    {
        while (true)
        {
            int n = int.Parse(Console.ReadLine());
            bool evenOrNot = Lecture2.isEven(n);
            if (evenOrNot)
            {
                break;
            }            
        }
    }
}
