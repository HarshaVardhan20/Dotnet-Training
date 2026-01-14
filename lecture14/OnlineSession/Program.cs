using System.Diagnostics.Contracts;
using System.Linq.Expressions;

namespace OnlineSession
{
    public class Employee
    {
        public string Name {get;set;}

        public int Age {get;set;}

        public decimal Salary{get;set;}

        public Employee(string name,int age,decimal salary)
        {
            Name = name;
            Age = age;
            Salary = salary;

            // Console.WriteLine($"Name is {name} Id is {id} Salary is {salary}");
        }
    }

    public class Program
    {
        public static void SecondLargest(List<Employee> employees)
        {
            int first = 0;
            int second = 0;
            int idx1 = -1;
            int idx2 = -1;
            for(int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Age > first)
                {
                    first = employees[i].Age;
                    idx1= i;
                }
                else if (employees[i].Age > second)
                {
                    second = employees[i].Age;
                    idx2 = i;
                }
            }
            Console.WriteLine($"Name is {employees[idx2].Name} Age is {employees[idx2].Age} salary is {employees[idx2].Salary}");
        }
        public static void Main()
        {
            List<Employee> employees =  new List<Employee>()
            {
                new Employee("Harsha",101,32433),
                new Employee("Harsha",102,32433),
                new Employee("Harsha",106,32433),
                new Employee("Harsha",103,32433)
            };
            SecondLargest(employees);
        }
    }
}