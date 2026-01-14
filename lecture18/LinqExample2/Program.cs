using Generics;

namespace Generics
{
    public delegate string delegateFunc();

    public string getHello()
    {   
        return "hello";
    }
    public string getHi()
    {
        return "Hi";
    }
    public class Student
    {
        public string? Name {get;set;}
    }
    public class UGStudent : Student
    {
        public int HighSchoolMarks {get;set;}
    }
    public class PGStudent : Student
    {
        public int UGMarks {get;set;}
    }
    public class MyGlobalType<T>
    {
        public string GetDataType(T t)
        {
            return typeof(T).Name;
        }

    }
} 

namespace MyConsoleApp
{
    public class CallerClass
    {
        public static void Main()
        {
            MyGlobalType<UGStudent> myGlobalType = new();
            UGStudent obj = new ();
            string result = myGlobalType.GetDataType(obj);
            System.Console.WriteLine(result);           
        }
    }
}