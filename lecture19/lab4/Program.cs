using System;
using System.Collections;
using System.Collections.Generic;

namespace YogaMeditationProblem4
{
    public class MeditationCenter
    {
        public int MemberId { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public string Goal { get; set; }
        public double BMI { get; set; }
    }

    public class Program
    {
        public static ArrayList memberList = new ArrayList();

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
    }
}