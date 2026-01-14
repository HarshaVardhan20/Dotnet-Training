using Question1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Question1
{
    public abstract class Employee
    {
        private int _id;
        private string _name;
        private string _email;
        private string _department;
        private DateTime _joinDate;
        private bool _isActive;

        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string EmployeeType { get; protected set; }

        public Employee(int id, string name, string email, string dept)
        {
            _id = id;
            _name = name;
            _email = email;
            _department = dept;
            _joinDate = DateTime.Now;
            _isActive = true;
        }

        public abstract PaySlip CalculateSalary();
    }

    public class FullTimeEmployee : Employee
    {
        public decimal BasicSalary { get; set; }
        public decimal Bonus { get; set; }

        public FullTimeEmployee(int id, string name, string email, string dept, decimal basic, decimal bonus)
            : base(id, name, email, dept)
        {
            BasicSalary = basic;
            Bonus = bonus;
            EmployeeType = "Full-Time";
        }

        public override PaySlip CalculateSalary()
        {
            decimal gross = BasicSalary + Bonus;
            decimal tax = gross * 0.10m;
            decimal net = gross - tax;

            return new PaySlip(Id, Name, EmployeeType, gross, tax, net);
        }
    }

    public class ContractEmployee : Employee
    {
        public decimal HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public ContractEmployee(int id, string name, string email, string dept, decimal rate, int hours)
            : base(id, name, email, dept)
        {
            HourlyRate = rate;
            HoursWorked = hours;
            EmployeeType = "Contract";
        }

        public override PaySlip CalculateSalary()
        {
            if (HoursWorked < 0) throw new ArgumentException("Hours cannot be negative");

            decimal gross = HourlyRate * HoursWorked;
            decimal tax = gross * 0.05m;
            decimal net = gross - tax;

            return new PaySlip(Id, Name, EmployeeType, gross, tax, net);
        }
    }
}