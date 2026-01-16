using System;
using System.Collections;
using System.Collections.Generic;

namespace YogaMeditationProblem4
{
    #region Inner Classes
    /// <summary>
    /// Data class representing a yoga meditation center member with health metrics and fitness goals.
    /// Stores information for BMI calculation and fee determination.
    /// </summary>
    public class MeditationCenter
    {
        /// <summary>Unique identifier for the member.</summary>
        public int MemberId { get; set; }
        /// <summary>The member's age in years.</summary>
        public int Age { get; set; }
        /// <summary>The member's weight in kilograms.</summary>
        public double Weight { get; set; }
        /// <summary>The member's height in meters.</summary>
        public double Height { get; set; }
        /// <summary>The member's fitness goal (e.g., "Weight Loss" or "Weight Gain").</summary>
        public string Goal { get; set; }
        /// <summary>The calculated Body Mass Index for the member.</summary>
        public double BMI { get; set; }
    }
    #endregion

    /// <summary>
    /// Program class for managing yoga meditation center members.
    /// Provides functionality to add members, calculate BMI, and determine yoga class fees.
    /// Fees are calculated based on BMI and fitness goals.
    /// </summary>
    public class Program
    {
        #region Fields
        /// <summary>
        /// Static ArrayList to store all registered yoga meditation center members.
        /// </summary>
        public static ArrayList memberList = new ArrayList();
        #endregion

        #region Helper Methods
        /// <summary>
        /// Adds a new yoga member to the member list with their health metrics and fitness goal.
        /// </summary>
        /// <param name="memberId">Unique identifier for the member.</param>
        /// <param name="age">The member's age.</param>
        /// <param name="weight">The member's weight in kilograms.</param>
        /// <param name="height">The member's height in meters.</param>
        /// <param name="goal">The member's fitness goal (e.g., "Weight Loss" or "Weight Gain").</param>
        public void AddYogaMember(int memberId, int age, double weight, double height, string goal)
        {
            MeditationCenter member = new MeditationCenter
            {
                MemberId = memberId,
                Age = age,
                Weight = weight,
                Height = height,
                Goal = goal
            };

            memberList.Add(member);
        }

        /// <summary>
        /// Calculates the Body Mass Index (BMI) for a member and updates their BMI value.
        /// BMI = weight / (height * height)
        /// Returns 0 if the member is not found.
        /// </summary>
        /// <param name="memberId">The ID of the member to calculate BMI for.</param>
        /// <returns>The calculated BMI value, or 0 if member not found.</returns>
        public double CalculateBMI(int memberId)
        {
            foreach (MeditationCenter member in memberList)
            {
                if (member.MemberId == memberId)
                {
                    double bmi = member.Weight / (member.Height * member.Height);
                    bmi = Math.Floor(bmi * 100) / 100;
                    member.BMI = bmi;
                    return bmi;
                }
            }
            return 0;
        }

        /// <summary>
        /// Calculates the yoga class fee for a member based on their goal and BMI.
        /// For "Weight Loss" goal: Rs 2000 (BMI 25-30), Rs 2500 (BMI 30-35), Rs 3000 (BMI >= 35)
        /// For "Weight Gain" goal: Rs 2500
        /// Returns 0 if the member is not found or goal is unrecognized.
        /// </summary>
        /// <param name="memberId">The ID of the member to calculate fee for.</param>
        /// <returns>The calculated yoga fee in rupees, or 0 if member not found.</returns>
        public int CalculateYogaFee(int memberId)
        {
            foreach (MeditationCenter member in memberList)
            {
                if (member.MemberId == memberId)
                {
                    if (member.Goal.Equals("Weight Loss"))
                    {
                        if (member.BMI >= 25 && member.BMI < 30)
                            return 2000;
                        else if (member.BMI >= 30 && member.BMI < 35)
                            return 2500;
                        else if (member.BMI >= 35)
                            return 3000;
                    }
                    else if (member.Goal.Equals("Weight Gain"))
                    {
                        return 2500;
                    }
                }
            }
            return 0;
        }
        #endregion

        #region UI Methods
        /// <summary>
        /// Prompts the user to enter yoga member information (ID, age, weight, height, goal).
        /// Validates all inputs and adds the member if all information is valid.
        /// </summary>
        public void AddYogaMember()
        {
            Console.Write("Enter Member Id: ");
            if (!int.TryParse(Console.ReadLine(), out int memberId))
            {
                Console.WriteLine("Invalid Member Id");
                return;
            }

            Console.Write("Enter Age: ");
            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine("Invalid Age");
                return;
            }

            Console.Write("Enter Weight: ");
            if (!double.TryParse(Console.ReadLine(), out double weight))
            {
                Console.WriteLine("Invalid Weight");
                return;
            }

            Console.Write("Enter Height: ");
            if (!double.TryParse(Console.ReadLine(), out double height))
            {
                Console.WriteLine("Invalid Height");
                return;
            }

            Console.Write("Enter Goal: ");
            string goal = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(goal))
            {
                Console.WriteLine("Invalid Goal");
                return;
            }

            AddYogaMember(memberId, age, weight, height, goal);
        }

        /// <summary>
        /// Prompts the user to enter a member ID and displays the calculated BMI for that member.
        /// Shows an error message if the member is not found.
        /// </summary>
        public void CalculateBMIUI()
        {
            Console.Write("Enter Member Id: ");
            if (!int.TryParse(Console.ReadLine(), out int memberId))
            {
                Console.WriteLine("Invalid Member Id");
                return;
            }

            double bmi = CalculateBMI(memberId);
            if (bmi == 0)
            {
                Console.WriteLine($"MemberId {memberId} is not present");
            }
            else
            {
                Console.WriteLine("BMI: " + bmi);
            }
        }

        /// <summary>
        /// Prompts the user to enter a member ID and displays the calculated yoga fee for that member.
        /// Shows an error message if the member is not found.
        /// </summary>
        public void CalculateYogaFeeUI()
        {
            Console.Write("Enter Member Id: ");
            if (!int.TryParse(Console.ReadLine(), out int memberId))
            {
                Console.WriteLine("Invalid Member Id");
                return;
            }

            int fee = CalculateYogaFee(memberId);
            if (fee == 0)
            {
                Console.WriteLine($"MemberId {memberId} is not present");
            }
            else
            {
                Console.WriteLine("Yoga Fee: " + fee);
            }
        }
        #endregion

        #region Main
        /// <summary>
        /// Main entry point providing a menu-driven interface for yoga center management:
        /// 1. Add new yoga member
        /// 2. Calculate BMI for a member
        /// 3. Calculate yoga fee for a member
        /// 4. Exit the program
        /// </summary>
        static void Main(string[] args)
        {
            Program p = new Program();
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("1. Add Yoga Member");
                Console.WriteLine("2. Calculate BMI");
                Console.WriteLine("3. Calculate Yoga Fee");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid choice");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        p.AddYogaMember();
                        break;

                    case 2:
                        p.CalculateBMIUI();
                        break;

                    case 3:
                        p.CalculateYogaFeeUI();
                        break;

                    case 4:
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }
        #endregion
    }
}