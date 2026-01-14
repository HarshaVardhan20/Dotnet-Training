

using Question1;
namespace Question1
{
    class Program
    {
        static void NotifyHR(PaySlip slip)
        {
            Console.WriteLine($"[HR Notification] Record updated for {slip.EmployeeName}. Net: {slip.NetPay}");
        }

        static void NotifyFinance(PaySlip slip)
        {
            Console.WriteLine($"[Finance Notification] Fund transfer initiated for Acc#{slip.EmployeeId}. Amount: {slip.NetPay}");
        }

        static void Main(string[] args)
        {
            PayrollProcessor processor = new PayrollProcessor();

            PayrollProcessor.AddData(processor);

            processor.OnSalaryProcessed += NotifyHR;
            processor.OnSalaryProcessed += NotifyFinance;

            processor.AddEmployee(new FullTimeEmployee(101, "Alice", "alice@corp.com", "IT", 50000, 5000));
            processor.AddEmployee(new FullTimeEmployee(102, "Bob", "bob@corp.com", "HR", 45000, 2000));
            processor.AddEmployee(new ContractEmployee(201, "Charlie", "charlie@corp.com", "Ops", 50, 160));
            processor.AddEmployee(new ContractEmployee(202, "Dave", "dave@corp.com", "Ops", 60, 100));

            processor.RunPayroll();

            processor.PrintSummary();

            Console.ReadLine();
        }
    }
}


