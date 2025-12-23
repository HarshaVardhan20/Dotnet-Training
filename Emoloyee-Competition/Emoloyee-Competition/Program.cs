using System;
using System.Collections.Generic;

public class Program
{
    public class Employee
    {
        public int Id { get; }
        public string Name { get; }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public class Competition
    {
        public string Name { get; }
        private HashSet<Employee> employees = new HashSet<Employee>();
        private int numberOfWinners;

        public Competition(string name, int winners)
        {
            Name = name;
            numberOfWinners = winners;
        }

        public void AddEmployee(Employee emp)
        {
            employees.Add(emp); 
        }

        public List<Employee> GetWinners()
        {
            List<Employee> winners = new List<Employee>();
            int count = 0;

            foreach (var emp in employees)
            {
                winners.Add(emp);
                count++;
                if (count == numberOfWinners)
                    break;
            }
            return winners;
        }
    }

    public static void Main(string[] args)
    {
        Employee e1 = new Employee(1, "Harsha");
        Employee e2 = new Employee(2, "John");
        Employee e3 = new Employee(3, "Adam");
        Employee e4 = new Employee(4, "Azaz");
        Employee e5 = new Employee(5, "Aaron");
        Employee e6 = new Employee(6, "Hero");
        Employee e7 = new Employee(7, "Cena");
        Employee e8 = new Employee(8, "Roman");
        Employee e9 = new Employee(9, "Zack");

        Competition c1 = new Competition("Comp1", 2);
        Competition c2 = new Competition("Comp2", 3);
        Competition c3 = new Competition("Comp3", 1);

        c1.AddEmployee(e1);
        c1.AddEmployee(e2);
        c1.AddEmployee(e3);

        c2.AddEmployee(e3);
        c2.AddEmployee(e4);
        c2.AddEmployee(e1);
        c2.AddEmployee(e8);
        c2.AddEmployee(e9);

        c3.AddEmployee(e1);
        c3.AddEmployee(e2);
        c3.AddEmployee(e3);

        Dictionary<int, int> empRank = new Dictionary<int, int>();

        ProcessWinners(c1, empRank);
        ProcessWinners(c2, empRank);
        ProcessWinners(c3, empRank);

        Console.WriteLine("\nFinal Rankings:");
        foreach (var kv in empRank)
        {
            Console.WriteLine($"Employee ID {kv.Key} -> Score {kv.Value}");
        }
    }

    private static void ProcessWinners(Competition comp, Dictionary<int, int> rank)
    {
        Console.WriteLine($"\nWinners of {comp.Name}:");
        foreach (var emp in comp.GetWinners())
        {
            Console.WriteLine($"{emp.Id} - {emp.Name}");
            if (rank.ContainsKey(emp.Id))
                rank[emp.Id]++;
            else
                rank[emp.Id] = 1;
        }
    }
}
