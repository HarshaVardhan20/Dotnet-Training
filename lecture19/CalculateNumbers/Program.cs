    /// <summary>
    /// Program class for calculating GPA and assigning grades based on numerical scores.
    /// Provides functionality to add numbers, calculate GPA, and determine corresponding grades.
    /// </summary>
    public class Program
    {
        #region Fields
        /// <summary>
        /// Static list to store all the numbers/scores entered by the user.
        /// </summary>
        public static List<int> NumberList = new List<int>();
        #endregion

        #region Methods - Add Numbers
        /// <summary>
        /// Adds a number to the NumberList. This is the primary method for number insertion.
        /// </summary>
        /// <param name="Numbers">The number to be added to the list.</param>
        public void AddNumbers(int Numbers)
        {
            NumberList.Add(Numbers);
        }

        /// <summary>
        /// Calculates the GPA (Grade Point Average) from all numbers in the list.
        /// Returns -1 if the list is empty, otherwise returns calculated GPA value.
        /// </summary>
        /// <returns>The calculated GPA or -1 if no numbers are available.</returns>
        public double GetGPAScored()
        {
            if (NumberList.Count == 0)
            {
                return -1;
            }
            var SubjectCount = NumberList.Count;
            double GPA = NumberList.Sum(n => n * 3)/(SubjectCount*3*10.0);
            return GPA;
        }
        /// <summary>
        /// Converts a GPA value to a corresponding letter grade (S, A, B, C, D, E).
        /// Returns space character if GPA is invalid.
        /// </summary>
        /// <param name="gpa">The GPA value to convert.</param>
        /// <returns>Letter grade corresponding to the GPA value.</returns>
        public char GetGradeScored(double gpa)
        {
            char grade = ' ';
            if (gpa == 10)
            {
                grade = 'S';
            }
            else if (gpa < 10 && gpa >= 9)
            {
                grade = 'A';
            }
            else if (gpa < 9 && gpa >= 8)
            {
                grade = 'B';
            }
            else if (gpa < 8 && gpa >= 7)
            {
                grade = 'C';
            }
            else if (gpa < 7 && gpa >= 6)
            {
                grade = 'D';
            }
            else if (gpa < 6 && gpa >= 5)
            {
                grade = 'E';
            }
            else
            {
                Console.WriteLine("Invalid GPA");
                return ' ';
            }
            return grade;
        }

        #endregion

        #region Methods - Get GPA and Grade
        /// <summary>
        /// Prompts the user to enter a number and adds it to the NumberList.
        /// Validates that the input is a valid integer.
        /// </summary>
        public void AddNumbers()
        {
            Console.Write("Enter Number: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                AddNumbers(number);
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
        }
        #endregion

        /// <summary>
        /// Calculates the GPA from the stored numbers and displays both the GPA and corresponding grade.
        /// Displays error message if no numbers are available.
        /// </summary>
        public void CalculateGPAAndGrade()
        {
            double gpa = GetGPAScored();

            if (gpa == -1)
            {
                Console.WriteLine("No Numbers Available");
                return;
            }

            Console.WriteLine($"GPA Scored: {gpa:F2}");

            char grade = GetGradeScored(gpa);
            if (grade != ' ')
            {
                Console.WriteLine("Grade: " + grade);
            }
        }

        #region Main
        /// <summary>
        /// Main entry point of the application. Provides a menu-driven interface for users to:
        /// 1. Add numbers to the list
        /// 2. Calculate GPA and get corresponding grade
        /// 3. Exit the program
        /// </summary>
        static void Main(string[] args)
        {
            Program p = new Program();
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("1. Add Number");
                Console.WriteLine("2. Calculate GPA and Grade");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid choice");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        p.AddNumbers();
                        break;

                    case 2:
                        p.CalculateGPAAndGrade();
                        break;

                    case 3:
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