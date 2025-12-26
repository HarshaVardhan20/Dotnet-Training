using System;
using System.Collections.Generic;
using System.Text;

namespace PayRollBoard
{
    public abstract class Employee
    {
        public string EmployeeName { get; set; }
        public double[] weeklyHours { get; set; }

        public Employee(string EmployeeName, double[] weeklyHours)
        {
            this.EmployeeName = EmployeeName;
            this.weeklyHours = weeklyHours;
        }

        public abstract double getMonthlyPay();
    }

    public class FullTimeEmployee: Employee
    {
        double HourlyRate { get; set; }
        double MonthlyBonus;
        public FullTimeEmployee(string EmployeeName, double[] weeklyHours, double hourlyRate,double monthlyBonus) : base(EmployeeName, weeklyHours)
        {
            HourlyRate = hourlyRate;
            MonthlyBonus = monthlyBonus;
        }
        public override double getMonthlyPay()
        {
            double total = 0;
            for (int i = 0; i < 4; i++)
            {
                total += (weeklyHours[i] * HourlyRate);
            }
            total += MonthlyBonus;
            return total;
        }
    }

    public class ContractEmployee: Employee
    {
        double HourlyRate { get; set; }
        public ContractEmployee(string EmployeeName, double[] weeklyHours, double hourlyRate) : base(EmployeeName, weeklyHours)
        {
            HourlyRate = hourlyRate;
        }
        public override double getMonthlyPay()
        {
            double total = 0;
            for(int i = 0; i < 4; i++)
            {
                total += (weeklyHours[i] * HourlyRate);
            }
            return total;
        }
    }


}
