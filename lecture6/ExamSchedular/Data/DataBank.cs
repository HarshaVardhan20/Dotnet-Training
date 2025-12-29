using System;
using System.Collections.Generic;
using System.Text;
using ExamSchedular.Data;
using ExamSchedular.Model;

namespace ExamSchedular.Data
{
    public static class DataBank
    {
        static List<Student> students = new List<Student>();
        static DataBank()
        {
            students.Add(new Student { Id = 1, Name = "Harsha" });
            students.Add(new Student { Id = 2, Name = "Vishnu" });
            students.Add(new Student{ Id = 3, Name = "Arun" });
            students.Add(new Student{ Id = 4, Name = "Bob" });
        }

        public static List<Student> getStudentsData()
        {
            return students;
        }
    }
}
