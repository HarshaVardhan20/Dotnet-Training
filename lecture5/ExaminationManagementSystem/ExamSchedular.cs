using System;
using System.Collections.Generic;

namespace ExaminationManagementSystem
{

    public abstract class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
    }

    public class Student
    {
        public int StudentId { get; private set; }
        public string StudentName { get; set; } 
        public int StudentAge { get; set; }
        public string Section { get; set; }
        public int Batch { get; set; }
        public Semester Semester { get; set; }
    }


    public class Department
    {
        public int DeptId { get; set; }
        public string DepartmentName { get; set; }

        public HOD Hod { get; set; }
        public List<Course> Courses { get; set; } = new();
        public List<Examiner> Examiners { get; set; } = new();
    }


    public class HOD : Employee
    {
        public Department Department { get; set; }

        public void ScheduleExam(ExamSchedule schedule)
        {
            Console.WriteLine($"HOD scheduled exam for Course {schedule.Exam.Course.CourseName}");
        }
    }

    public class Examiner : Employee
    {
        public Department Department { get; set; }
    }


    public class Semester
    {
        public int SemesterId { get; set; }
        public int SemesterNumber { get; set; }
    }

    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; private set; }
        public Department Department { get; set; }

        public Course(string name)
        {
            CourseName = name;
        }
    }

    public class Section
    {
        public int SectionId { get; set; }

    }

    public class Exam
    {
        public int ExamId { get; set; }
        public Course Course { get; set; }
        public Semester Semester { get; set; }
        public DateTime ExamDate { get; set; }
        public int DurationMinutes { get; set; }
    }


    public class Room
    {
        public int RoomId { get; set; }
        public int RoomNo { get; set; }
    }

    public class Block
    {
        public int BlockId { get; set; }
        public string BlockName { get; set; }
    }


    public class ExamSchedule
    {
        public int ScheduleId { get; set; }
        public Exam Exam { get; set; }
        public Examiner AssignedExaminer { get; set; }
        public Room Room { get; set; }
        public Block Block { get; set; }
    }
}
