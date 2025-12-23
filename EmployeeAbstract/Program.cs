namespace EmployeeAbstract
{

    public abstract class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public double salary { get; set; }

        public abstract double CalcTax();
    }

    public class UsEmployee: Employee
    {
        public override double CalcTax()
        {
            return salary * 0.6;
        }
    }
    
    public class IndianEmployee: Employee
    {
        public override double CalcTax()
        {
            return salary * 0.7;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            UsEmployee usEmp = new UsEmployee { EmployeeId = 1, EmployeeName = "UsEmployee", salary = 23435.40 };
            IndianEmployee indEmp = new IndianEmployee { EmployeeId = 1, EmployeeName = "IndianEmployee", salary = 23435.40 };
            Console.WriteLine(usEmp.CalcTax());
            Console.WriteLine(indEmp.CalcTax());
        }
    }

}