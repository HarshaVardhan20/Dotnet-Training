namespace ExaminationManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course c1 = new Course { CourseId = 1, CourseName = "OS", DepartmentId = 1 };

            Department d1 = new Department { DeptId = 1, DepartmentName = "CS" };
            HOD hod = new HOD { DepartmentId = 1, EmpId=1,Name="HOD 1" };
            Section section1 = new Section{ SectionId = 1 };
            Student s1 = new Student { StudentId = 1, StudentName = "Student 1", StudentAge = 20, Batch = 2026 };
            Semester semester1 = new Semester { SemesterId = 1 };
            

        }

    }
}
