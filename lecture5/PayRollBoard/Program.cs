using System.Numerics;
using System.Runtime.InteropServices.Swift;
using System.Security.Cryptography.X509Certificates;

namespace PayRollBoard
{
    public class Program
    {
        public static List<Employee> EmployeePayRoll = new List<Employee>() {};
        public void RegisterEmployee(Employee employee) {
            EmployeePayRoll.Add(employee);
            Console.WriteLine("Employee registered successfully!");
        }
        public void inputEmployee()
        {
            Console.WriteLine("Select Employee Type (1-Full Time, 2-Contract): ");
            string? EmpTypeInput = Console.ReadLine();
            Console.WriteLine("Enter Employee Name: ");
            if(int.TryParse(EmpTypeInput, out int EmpType) && EmpType<=2 && EmpType >= 1)
            {
                string? EmpNameInput = Console.ReadLine();
                Console.WriteLine("Enter Hourly Rate: ");
                string? MonthlyBonusInput="0";
                string? HourlyRateInput = Console.ReadLine();
                if (EmpType == 1) { 
                    Console.WriteLine("Enter Monthly Bonus: ");
                    MonthlyBonusInput = Console.ReadLine();
                }
                Console.WriteLine("Enter weekly hours (week 1 to week 4): ");
                string? week1HoursInput = Console.ReadLine();
                string? week2HoursInput = Console.ReadLine();
                string? week3HoursInput = Console.ReadLine();
                string? week4HoursInput = Console.ReadLine();
                if (double.TryParse(HourlyRateInput, out double HourlyRate) && !string.IsNullOrEmpty(EmpNameInput) 
                    //&& double.TryParse(MonthlyBonusInput, out double MonthlyBonus) 
                    && (int.TryParse(week1HoursInput, out int week1Hours) &&
                    (int.TryParse(week2HoursInput, out int week2Hours) &&
                    (int.TryParse(week3HoursInput, out int week3Hours) &&
                    (int.TryParse(week4HoursInput, out int week4Hours) 
                    )))))
                {
                    double[] weeklyHours = { week1Hours,week2Hours,week3Hours,week4Hours };
                    if (EmpType == 1 && double.TryParse(MonthlyBonusInput, out double MonthlyBonus)) {
                        FullTimeEmployee ftEmp = new FullTimeEmployee(EmpNameInput, weeklyHours, HourlyRate, MonthlyBonus);
                        RegisterEmployee(ftEmp);
                    }
                    else
                    {
                        ContractEmployee ctEmp = new ContractEmployee(EmpNameInput, weeklyHours, HourlyRate);
                        RegisterEmployee(ctEmp);
                    }
                }
                else
                {                                                           
                    Console.WriteLine("Enter correct values");
                }
            }
            else
            {
                Console.WriteLine("Employee type has to be 1 or 2");
            }
             
        }
        public void ShowOverTime()
        {
            Console.WriteLine("Enter hours threshold:");
            string? thresholdInput = Console.ReadLine();
            
            if(int.TryParse(thresholdInput, out int threshold) && threshold>0) 
            {
                bool flag = true;
                for (int i = 0; i < EmployeePayRoll.Count; i++) {
                    string name = EmployeePayRoll[i].EmployeeName;
                    int count = 0;
                    for(int j = 0; j < 4; j++)
                    {
                        if (EmployeePayRoll[i].weeklyHours[j] >= threshold)
                        {
                            count++;
                        }
                    }
                    if (count > 0)
                    {
                        flag = false;
                        Console.WriteLine($"{name} {count}");
                    }
                }
                if (flag)
                {
                    Console.WriteLine("No Overtime recorded this month");
                }
            }
            else
            {
                Console.WriteLine("Enter valid Threshold");
            }
        }

        public void printAverageMonthlyPay()
        {
            double total = 0;
            for (int i = 0; i < EmployeePayRoll.Count; i++) {
                total += EmployeePayRoll[i].getMonthlyPay();
            }
            Console.WriteLine($"Overall average Monthly Pay: {total/EmployeePayRoll.Count}");
        }
        public static void Main()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1. Register Employee");
                Console.WriteLine("2. Show Overtime Summary");
                Console.WriteLine("3. Calculate Averate Monthly Pay");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice");
                String? input = Console.ReadLine(); 
                Program p = new Program();
                if(int.TryParse(input, out int val))
                {
                    switch (val)
                    {
                        case 1:
                            p.inputEmployee();
                            break;
                        case 2:
                            p.ShowOverTime();
                            break;
                        case 3:
                            p.printAverageMonthlyPay();
                            break;
                        case 4:
                            Console.WriteLine("Logging off -- Payroll processed successfully!");
                            flag = false;
                            break;
                    }
                }
            }
        }
        
    }
}
