using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

public class LinqExample
{
    public class LinqStudent
    {
        public string Name {get;set;}
    }
    public class MyProcess()
    {
        public string Name {get;set;}
        public int Id {get;set;}
    }
    public static string IsPalindrome(string name)
    {
        if(name.Reverse() == name)
        {
            return "Palindrome " + name;
        }
        return "Not a palindrmoe " + name;
    }
    public static void LinqExample2(){
        var proCollection = from p in System.Diagnostics.Process.GetProcesses() select new MyProcess(){Name = p.ProcessName, Id = p.Id};
        foreach(var proc in proCollection)
        {
            Console.WriteLine($" Process Name = {proc.Name} Id = {proc.Id}");
        }
    }
    public static void LinqExample3(){
        var proCollection = from p in System.Diagnostics.Process.GetProcesses() select new {Name = p.ProcessName, Id = p.Id};
        foreach(var proc in proCollection)
        {
            Console.WriteLine($" Process Name = {proc.Name} Id = {proc.Id}");
        }
    }
    public class StudentMarks
    {
        public string name {get;set;}
        public int rollId {get;set;}
        public int marks1 {get;set;}
        public int marks2 {get;set;}
    }
    public static void Main()
    {
        string[] names = {"A","B","C","D"};
        foreach(var item in names)
        {
            if (item == "B")
            {
                Console.WriteLine("B is present");
            }
        }

        var findNames = from name in names orderby name ascending select IsPalindrome(name);

        foreach(var name in findNames)
        {
            Console.WriteLine(name);
        }

        var LinqStudents = from name in names orderby name ascending select new LinqStudent(){Name=name}; // Ananymous

        foreach(var linqstudent in LinqStudents)
        {
            Console.WriteLine(linqstudent.Name);
        }

        // LinqExample2();
        LinqExample3();

        // Ananymous Class -> Class created by microsoft when we don't mention any class name.
        
        StudentMarks[] studentsMarks = {
            new StudentMarks{name = "Harsha",rollId=1,marks1 = 39,marks2 = 50},
            new StudentMarks{name = "Tiluck",rollId=2,marks1 = 56,marks2 = 50},
            new StudentMarks{name = "Vishwanath",rollId=3,marks1 = 39,marks2 = 40}
        };

        var HighestAvg = studentsMarks.Max(s=> (s.marks1 + s.marks2)/2);
        var Highest = (from student in studentsMarks select (student.marks1 + student.marks2)/2).Max();
        Console.WriteLine(Highest);

        List<int> l = new List<int>{1,2,4};

        

    }
}