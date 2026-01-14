using System;
using System.Collections.Generic;
using System.Text;

namespace Question1
{
    public class PaySlip
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Type { get; set; }
        public decimal GrossPay { get; set; }
        public decimal Deductions { get; set; }
        public decimal NetPay { get; set; }
        public DateTime ProcessedDate { get; set; }

        public PaySlip(int id, string name, string type, decimal gross, decimal ded, decimal net)
        {
            EmployeeId = id;
            EmployeeName = name;
            Type = type;
            GrossPay = gross;
            Deductions = ded;
            NetPay = net;
            ProcessedDate = DateTime.Now;
        }

        public override string ToString()
        {
            return $"ID: {EmployeeId} | Name: {EmployeeName} ({Type}) | Net: {NetPay:C}";
        }
    }
}