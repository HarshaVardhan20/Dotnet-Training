using System;
using System.Numerics;

public class lab5
{
    public static void Main()
    {
        /// Input marks
        Console.WriteLine("Enter marks of subjects (Math, Physics, Chemistry): ");
        // Read marks for three subjects
        String marks1 = Console.ReadLine();
        String marks2 = Console.ReadLine();
        String marks3 = Console.ReadLine();
        /// condition to check whether student is eligible
        if(int.TryParse(marks1,out int math) && int.TryParse(marks2,out int phy) && int.TryParse(marks3,out int chem)
         && math>=0 && math<=100 && phy>=0 && phy<=100 && chem>=0 && chem<=100)
        {
            int total = math + phy + chem;
            // Check eligibility criteria
            if(math>=65 && phy>=55 && chem>=55 && (total>=180 || (math + phy > 140)))
            {
                Console.WriteLine("You are eligible");
            }
            else
            {
                Console.WriteLine("You are not eligible");
            }
        }
        else
        {
            Console.WriteLine("Enter valid marks");
        }
    }
}