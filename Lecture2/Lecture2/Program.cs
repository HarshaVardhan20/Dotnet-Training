using System;


public class Program
{
    /// <summary>
    ///    Student Defination
    /// </summary>
    
    public class Student
    {
        #region Decleration
        public int Id; 
        public string Name; 
        #endregion

        #region constructor
        public Student(int id, string name)
        {
            Id = id;    
            Name = name;
        }
        #endregion

        #region Member function
        public String getName()
        {
            return Name; 
        }

        public void setName(String name)
        {
            Name = name;
        }
        #endregion

    }
    public static void Main(string[] args) {

        Student student = new Student(1, "Harsha");
        Console.WriteLine(student.getName());
    }
}