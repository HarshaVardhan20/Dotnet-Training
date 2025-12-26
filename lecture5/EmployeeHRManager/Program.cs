namespace EmployeeHRManager
{
    public class Employee
    {
        protected int EmpId;
        protected string EmpName;

        protected double salary;

        protected string department;

        public Employee(int empId, string empName, double salary, string department)
        {
            EmpId = empId;
            EmpName = empName;
            this.salary = salary;
            this.department = department;
        }
    }

    public class HR : Employee {

        public HR(int empId, string empName, double salary, string department) : base(empId, empName, salary, department)
        {

        }
       
        
        
    }
    public class Program
    {
        HR hr = new HR(1,"kjshdfj",3224323,"sdfsaf");
    }
}
